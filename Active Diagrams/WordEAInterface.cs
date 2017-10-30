using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml;

//Flags images taken from http://www.free-country-flags.com/index.php

namespace Active_Diagrams
{
    public class EADiagram
    {
        public string Name;
        public string GUID;
        public string Author;
        public string Stereotype;
        public string Note;
        public string Type;
        public DateTime CreatedAt;
        public DateTime ModifiedAt;

        public EADiagram(string Name, string GUID)
        {
            this.Name = Name;
            this.GUID = GUID;
        }

        public EADiagram(string Name, string GUID, string Author, string Stereotype, 
                         string Note, string Type, DateTime CreatedAt, DateTime ModifiedAt)
        {
            this.Name = Name;
            this.GUID = GUID;
            this.Author = Author;
            this.Stereotype = Stereotype;
            this.Note = Note;
            this.Type = Type;
            this.CreatedAt = CreatedAt;
            this.ModifiedAt = ModifiedAt;
        }
    }


   


    public class EAPackage
    {
        EAPackage Owner;
        public List<EAPackage> OwnedPackages { get; set; }
        public List<EADiagram> OwnedDiagrams { get; set; }
        public string Name { get; set; }
        public int ID { get; set; }
        public EAPackage(string aName, int aID, EAPackage aOwner)
        {
            Name = aName;
            Owner = aOwner;
            ID = aID;
            OwnedPackages = new List<EAPackage>(); 
            OwnedDiagrams = new List<EADiagram>(); 
        }
    }

 


    public class WordEAInterface
    {
        /// <summary>
        /// Name of a custom property where the filename (connection string) for EA repository is stored.
        /// </summary>
        private string CustomPropertyName = "EAPFILE";
        /// <summary>
        /// For testing purposes. Change to empty string when making final build
        /// </summary>
        private string DefaultEAPFile = "";

        /// <summary>
        /// Filename or connection string for EA repository.
        /// </summary>
        public string EAPConnectionString
        {
            get { return ReadDocumentProperty(CustomPropertyName); }
            set { CloseEARepository();  WriteDocumentProperty(CustomPropertyName, value); }
        }

        private bool IsEAOpened = false;
        private EA.Repository _EARepository = null;
        protected EA.Repository EARepository { get { if (_EARepository == null) _EARepository = new EA.Repository(); return _EARepository; } }
        
        public void OpenEARepository()
        {
            if (!IsEAOpened)
            {
                try
                {
                    Cursor.Current = Cursors.WaitCursor;
                    if (_connectionString != "")
                    {
                        _connectionString = ""; 
                        EARepository.OpenFile(_connectionString);
                    }
                    else
                        EARepository.OpenFile(EAPConnectionString);
                    IsEAOpened = true;
                }
                finally
                {
                    Cursor.Current = Cursors.Default;
                }
            }
        }

        public void CloseEARepository()
        {
            if (IsEAOpened)
            {
                EARepository.CloseFile();
                //EARepository.Exit();
                IsEAOpened = false;
            }
        }

        public void ExitRepository()
        {
            try
            {
                if (_EARepository != null)
                {
                    EARepository.Exit();
                    IsEAOpened = false;
                }
            }
            catch (System.Exception)
            {
                //Neřeším to
            }
        }

        public void RefreshEARepository()
        {
            CloseEARepository();
            OpenEARepository();
        }


        private string _connectionString = ""; 
        public void PrepareForThreadRefresh()
        {
            _connectionString = EAPConnectionString;
        }



        public List<EADiagram> SearchDiagrams(string SearchTerm, bool ExactMatch = false, bool CaseSensitive = false, bool RegExpr = false)
        {
            List<EADiagram> result = new List<EADiagram>();

            string SQLCommand;

            switch (EARepository.RepositoryType())
            {
                case "ACCESS2007": // .accdb file, MS Access 2007+ format 
                case "JET": // .EAP file, MS Access 97 to 2003 format 
                    SQLCommand = "SELECT DIAGRAM_ID, EA_GUID, DIAGRAM_TYPE, NAME, AUTHOR, STEREOTYPE FROM T_DIAGRAM"; break;
                case "POSTGRES": //PostgreSQL
                    SQLCommand = "SELECT DIAGRAM_ID as \"DIAGRAM_ID\", EA_GUID as \"EA_GUID\", DIAGRAM_TYPE as \"DIAGRAM_TYPE\", NAME as \"NAME\", AUTHOR as \"AUTHOR\", STEREOTYPE as \"STEREOTYPE\" FROM T_DIAGRAM"; break;

                case "ASA": //Sybase SQL Anywhere 
                case "SQLSVR": //Microsoft SQL Server
                case "MYSQL": //MySQL
                case "ORACLE": //Oracle
                default: SQLCommand = "SELECT DIAGRAM_ID, EA_GUID, DIAGRAM_TYPE, NAME, AUTHOR, STEREOTYPE FROM T_DIAGRAM"; break;
            }

            string xmlDiagrams = EARepository.SQLQuery(SQLCommand);

            XmlDocument xml = new XmlDocument();
            xml.LoadXml(xmlDiagrams);

            if (!CaseSensitive)
                SearchTerm = SearchTerm.ToUpper();

            foreach (XmlNode row in xml.SelectNodes("/EADATA/Dataset_0/Data/Row"))
            {
                string name = row.SelectSingleNode("NAME").InnerText;
                if (!RegExpr && !CaseSensitive)
                    name = name.ToUpper();

                if (
                       (RegExpr && Regex.IsMatch(name, SearchTerm))
                       ||
                       (!RegExpr && 
                           (
                               (ExactMatch && (name == SearchTerm))
                               ||
                               (!ExactMatch && name.Contains(SearchTerm))
                           )
                       )
                   )
                {
                    result.Add(new EADiagram (row.SelectSingleNode("NAME").InnerText,
                                              row.SelectSingleNode("EA_GUID").InnerText,
                                              row.SelectSingleNode("AUTHOR").InnerText,
                                              row.SelectSingleNode("STEREOTYPE").InnerText,
                                              "",
                                              row.SelectSingleNode("DIAGRAM_TYPE").InnerText,
                                              DateTime.MinValue,
                                              DateTime.MinValue));
                }


            }


            return result;
        }


        public string GetFileName(string DiagramGUID) => System.IO.Path.GetTempPath() + DiagramGUID + ".emf";

        protected bool isGUIDDiagram(string GUID) { try { return EARepository.GetDiagramByGuid(GUID)!=null; } catch { return false; } }

        /// <summary>
        /// Save diagram identified by DiagramGUID into a file stored into temporary directory.
        /// Returns true if the operation is successful. 
        /// </summary>
        /// <param name="DiagramGUID"></param>
        /// <returns></returns>
        public bool SaveDiagramIntoFile(string DiagramGUID)
        {
            return isGUIDDiagram (DiagramGUID) ? EARepository.GetProjectInterface().PutDiagramImageToFile(DiagramGUID, GetFileName(DiagramGUID), 0): false;
        }

        /// <summary>
        /// Returns a diagram object (EADiagram) identified by DiagramGUID.
        /// </summary>
        /// <param name="DiagramGUID"></param>
        /// <returns></returns>
        public EADiagram GetDiagram(string DiagramGUID)
        {
            EA.Diagram diagram = EARepository.GetDiagramByGuid(DiagramGUID);
            
            EADiagram result = new EADiagram(diagram.Name, diagram.DiagramGUID, diagram.Author, 
                                             diagram.Stereotype, diagram.Notes, diagram.Type,
                                             diagram.CreatedDate, diagram.ModifiedDate);
            return result; 
        }

        private string ReadDocumentProperty(string propertyName)
        {
            Microsoft.Office.Core.DocumentProperties properties;
            properties = (Microsoft.Office.Core.DocumentProperties)Globals.ThisAddIn.Application.ActiveDocument.CustomDocumentProperties;

            foreach (Microsoft.Office.Core.DocumentProperty prop in properties)
            {
                if (prop.Name == propertyName)
                {
                    return prop.Value.ToString();
                }
            }
            return DefaultEAPFile;
        }

        private void WriteDocumentProperty(string propertyName, string propertyValue)
        {
            Microsoft.Office.Core.DocumentProperties properties;
            properties = (Microsoft.Office.Core.DocumentProperties)Globals.ThisAddIn.Application.ActiveDocument.CustomDocumentProperties;

            foreach (Microsoft.Office.Core.DocumentProperty prop in properties)
            {
                if (prop.Name == propertyName)
                {
                    prop.Type = Microsoft.Office.Core.MsoDocProperties.msoPropertyTypeString;
                    prop.Value = propertyValue;
                    return;
                }
            }

            properties.Add(propertyName, false, Microsoft.Office.Core.MsoDocProperties.msoPropertyTypeString, propertyValue);
        }

        private List<EAPackage> _models = null;
        public List<EAPackage> Models
        {
            get
            {
                if (_models == null)
                    _models = ReadPackages(null);
                return _models;
            }
        }


        public List<EAPackage> ReadPackages(EAPackage Package)
        {
            

            if (Package == null)
            {
                List<EAPackage> result = new List<EAPackage>();
                foreach (EA.Package pkg in EARepository.Models)
                    result.Add(new EAPackage(pkg.Name, pkg.PackageID, null));
                return result;
            }
            else
            {
                Package.OwnedPackages = new List<EAPackage>();
                Package.OwnedDiagrams = new List<EADiagram>();

                foreach (EA.Package pkg in EARepository.GetPackageByID(Package.ID).Packages)
                    Package.OwnedPackages.Add(new EAPackage(pkg.Name, pkg.PackageID, Package));

                foreach (EA.Diagram diag in EARepository.GetPackageByID(Package.ID).Diagrams)
                {
                    Package.OwnedDiagrams.Add(new EADiagram(diag.Name, diag.DiagramGUID));
                }

                return Package.OwnedPackages;
            }
        }

    }
}