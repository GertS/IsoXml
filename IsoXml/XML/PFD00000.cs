﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.34209
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Xml.Serialization;

// 
// Этот исходный код был создан с помощью xsd, версия=4.0.30319.33440.
// 
namespace IsoXml.XML.field
{

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class LSG
    {

        private LSGPNT[] pNTField;

        private string aField;

        private string bField;

        //private string p102_IDField;

        //private string p102_PATHTYPEField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PNT", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public LSGPNT[] PNT
        {
            get
            {
                return this.pNTField;
            }
            set
            {
                this.pNTField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string A
        {
            get
            {
                return this.aField;
            }
            set
            {
                this.aField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string B
        {
            get
            {
                return this.bField;
            }
            set
            {
                this.bField = value;
            }
        }

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlAttributeAttribute()]
    //    public string P102_ID
    //    {
    //        get
    //        {
    //            return this.p102_IDField;
    //        }
    //        set
    //        {
    //            this.p102_IDField = value;
    //        }
    //    }

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlAttributeAttribute()]
    //    public string P102_PATHTYPE
    //    {
    //        get
    //        {
    //            return this.p102_PATHTYPEField;
    //        }
    //        set
    //        {
    //            this.p102_PATHTYPEField = value;
    //        }
    //    }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class LSGPNT
    {

        private string aField;

        private string cField;

        private string dField;

        private string bField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string A
        {
            get
            {
                return this.aField;
            }
            set
            {
                this.aField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string C
        {
            get
            {
                return this.cField;
            }
            set
            {
                this.cField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string D
        {
            get
            {
                return this.dField;
            }
            set
            {
                this.dField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string B
        {
            get
            {
                return this.bField;
            }
            set
            {
                this.bField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class XFC
    {

        private object[] itemsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("LSG", typeof(LSG))]
        [System.Xml.Serialization.XmlElementAttribute("PFD", typeof(PFD), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public object[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PFD
    {

        private XFCPFDPLN[] pLNField;

        private LSG[] lSGField;

        private string aField;

        private string cField;

        private string dField;

        private string fField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PLN", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public XFCPFDPLN[] PLN
        {
            get
            {
                return this.pLNField;
            }
            set
            {
                this.pLNField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("LSG")]
        public LSG[] LSG
        {
            get
            {
                return this.lSGField;
            }
            set
            {
                this.lSGField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string A
        {
            get
            {
                return this.aField;
            }
            set
            {
                this.aField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string C
        {
            get
            {
                return this.cField;
            }
            set
            {
                this.cField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string D
        {
            get
            {
                return this.dField;
            }
            set
            {
                this.dField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string F
        {
            get
            {
                return this.fField;
            }
            set
            {
                this.fField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class XFCPFDPLN
    {

        private LSG[] lSGField;

        private string aField;

        private string bField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("LSG")]
        public LSG[] LSG
        {
            get
            {
                return this.lSGField;
            }
            set
            {
                this.lSGField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string A
        {
            get
            {
                return this.aField;
            }
            set
            {
                this.aField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string B
        {
            get
            {
                return this.bField;
            }
            set
            {
                this.bField = value;
            }
        }
    }
}