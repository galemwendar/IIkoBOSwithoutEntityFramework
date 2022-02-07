using System.IO;
using System.Xml.Serialization;

namespace iiko_it_getversion_API
{

    /// <summary>
    /// Здесь хранится результат десериализации xml строки ServerProperties
    /// </summary>
    public class ServerProperties
    {
        private r mDeserializatedResult;


        public ServerProperties(string xml)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(r));
            using (var sr = new StringReader(xml))
            {
                mDeserializatedResult = (r)serializer.Deserialize(sr);
            }
        }


        public string ServerName
        {
            get
            {
                return mDeserializatedResult.serverName;
            }
            set
            {
                mDeserializatedResult.serverName = value;
            }
        }
        public string Edition
        {
            get
            {
                return mDeserializatedResult.edition;
            }
            set
            {
                mDeserializatedResult.edition = value;
            }
        }

        public string Version
        {
            get
            {
                return mDeserializatedResult.version;
            }
            set
            {
                mDeserializatedResult.version = value;
            }
        }
        public string computerName
        {
            get
            {
                return mDeserializatedResult.computerName;
            }
            set
            {
                mDeserializatedResult.computerName = value;
            }
        }


        public string ServerState
        {
            get
            {
                return mDeserializatedResult.serverState;
            }
            set
            {
                mDeserializatedResult.serverState = value;
            }
        }

        public string protocol
        {
            get
            {
                return mDeserializatedResult.protocol;
            }
            set
            {
                mDeserializatedResult.protocol = value;
            }
        }
        public string serverAddr
        {
            get
            {
                return mDeserializatedResult.serverAddr;
            }
            set
            {
                mDeserializatedResult.serverAddr = value;
            }
        }
        public string serverSubUrl
        {
            get
            {
                return mDeserializatedResult.serverSubUrl;
            }
            set
            {
                mDeserializatedResult.serverSubUrl = value;
            }
        }
        public ushort port
        {
            get
            {
                return mDeserializatedResult.port;
            }
            set
            {
                mDeserializatedResult.port = value;
            }
        }
        public bool isPresent
        {
            get
            {
                return mDeserializatedResult.isPresent;
            }
            set
            {
                mDeserializatedResult.isPresent = value;
            }
        }



        // Примечание. Для запуска созданного кода может потребоваться NET Framework версии 4.5 или более поздней версии и .NET Core или Standard версии 2.0 или более поздней.
        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
        public partial class r
        {

            private string serverNameField;

            private string editionField;

            private string versionField;

            private string computerNameField;

            private string serverStateField;

            private string protocolField;

            private string serverAddrField;

            private string serverSubUrlField;

            private ushort portField;

            private bool isPresentField;

            /// <remarks/>
            public string serverName
            {
                get
                {
                    return this.serverNameField;
                }
                set
                {
                    this.serverNameField = value;
                }
            }

            /// <remarks/>
            public string edition
            {
                get
                {
                    return this.editionField;
                }
                set
                {
                    this.editionField = value;
                }
            }

            /// <remarks/>
            public string version
            {
                get
                {
                    return this.versionField;
                }
                set
                {
                    this.versionField = value;
                }
            }

            /// <remarks/>
            public string computerName
            {
                get
                {
                    return this.computerNameField;
                }
                set
                {
                    this.computerNameField = value;
                }
            }

            /// <remarks/>
            public string serverState
            {
                get
                {
                    return this.serverStateField;
                }
                set
                {
                    this.serverStateField = value;
                }
            }


            /// <remarks/>
            public string protocol
            {
                get
                {
                    return this.protocolField;
                }
                set
                {
                    this.protocolField = value;
                }
            }

            /// <remarks/>
            public string serverAddr
            {
                get
                {
                    return this.serverAddrField;
                }
                set
                {
                    this.serverAddrField = value;
                }
            }

            /// <remarks/>
            public string serverSubUrl
            {
                get
                {
                    return this.serverSubUrlField;
                }
                set
                {
                    this.serverSubUrlField = value;
                }
            }

            /// <remarks/>
            public ushort port
            {
                get
                {
                    return this.portField;
                }
                set
                {
                    this.portField = value;
                }
            }

            /// <remarks/>
            public bool isPresent
            {
                get
                {
                    return this.isPresentField;
                }
                set
                {
                    this.isPresentField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class configUpdate
        {

            private string urlField;

            /// <remarks/>
            public string Url
            {
                get
                {
                    return this.urlField;
                }
                set
                {
                    this.urlField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class configItem
        {

            private configItemKey keyField;

            private configItemValue valueField;

            /// <remarks/>
            public configItemKey key
            {
                get
                {
                    return this.keyField;
                }
                set
                {
                    this.keyField = value;
                }
            }

            /// <remarks/>
            public configItemValue value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class configItemKey
        {

            private string stringField;

            /// <remarks/>
            public string @string
            {
                get
                {
                    return this.stringField;
                }
                set
                {
                    this.stringField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class configItemValue
        {

            private object dateTimeField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
            public object dateTime
            {
                get
                {
                    return this.dateTimeField;
                }
                set
                {
                    this.dateTimeField = value;
                }
            }
        }
    }
}

