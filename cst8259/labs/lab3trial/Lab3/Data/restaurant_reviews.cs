﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Xml.Serialization;

// 
// This source code was auto-generated by xsd, Version=4.8.3928.0.
// 


/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.algonquincollege.com/cst8259/labs")]
[System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.algonquincollege.com/cst8259/labs", IsNullable=false)]
public partial class restaurants {
    
    private restaurantsRestaurant[] restaurantField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("restaurant")]
    public restaurantsRestaurant[] restaurant {
        get {
            return this.restaurantField;
        }
        set {
            this.restaurantField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.algonquincollege.com/cst8259/labs")]
public partial class restaurantsRestaurant {
    
    private restaurantsRestaurantGeneralInfo generalInfoField;
    
    private restaurantsRestaurantReview reviewField;
    
    private restaurantsRestaurantMenuItem[] menuField;
    
    /// <remarks/>
    public restaurantsRestaurantGeneralInfo generalInfo {
        get {
            return this.generalInfoField;
        }
        set {
            this.generalInfoField = value;
        }
    }
    
    /// <remarks/>
    public restaurantsRestaurantReview review {
        get {
            return this.reviewField;
        }
        set {
            this.reviewField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("menuItem", IsNullable=false)]
    public restaurantsRestaurantMenuItem[] menu {
        get {
            return this.menuField;
        }
        set {
            this.menuField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.algonquincollege.com/cst8259/labs")]
public partial class restaurantsRestaurantGeneralInfo {
    
    private string nameField;
    
    private string websiteField;
    
    private restaurantsRestaurantGeneralInfoLogo logoField;
    
    private address addressField;
    
    private restaurantsRestaurantGeneralInfoPhone phoneField;
    
    private restaurantsRestaurantGeneralInfoRating ratingField;
    
    private string cuisineField;
    
    private restaurantsRestaurantGeneralInfoPriceRange priceRangeField;
    
    /// <remarks/>
    public string name {
        get {
            return this.nameField;
        }
        set {
            this.nameField = value;
        }
    }
    
    /// <remarks/>
    public string website {
        get {
            return this.websiteField;
        }
        set {
            this.websiteField = value;
        }
    }
    
    /// <remarks/>
    public restaurantsRestaurantGeneralInfoLogo logo {
        get {
            return this.logoField;
        }
        set {
            this.logoField = value;
        }
    }
    
    /// <remarks/>
    public address address {
        get {
            return this.addressField;
        }
        set {
            this.addressField = value;
        }
    }
    
    /// <remarks/>
    public restaurantsRestaurantGeneralInfoPhone phone {
        get {
            return this.phoneField;
        }
        set {
            this.phoneField = value;
        }
    }
    
    /// <remarks/>
    public restaurantsRestaurantGeneralInfoRating rating {
        get {
            return this.ratingField;
        }
        set {
            this.ratingField = value;
        }
    }
    
    /// <remarks/>
    public string cuisine {
        get {
            return this.cuisineField;
        }
        set {
            this.cuisineField = value;
        }
    }
    
    /// <remarks/>
    public restaurantsRestaurantGeneralInfoPriceRange priceRange {
        get {
            return this.priceRangeField;
        }
        set {
            this.priceRangeField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.algonquincollege.com/cst8259/labs")]
public partial class restaurantsRestaurantGeneralInfoLogo {
    
    private string altTextField;
    
    private restaurantsRestaurantGeneralInfoLogoDimensions dimensionsField;
    
    private string sourceField;
    
    /// <remarks/>
    public string altText {
        get {
            return this.altTextField;
        }
        set {
            this.altTextField = value;
        }
    }
    
    /// <remarks/>
    public restaurantsRestaurantGeneralInfoLogoDimensions dimensions {
        get {
            return this.dimensionsField;
        }
        set {
            this.dimensionsField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string source {
        get {
            return this.sourceField;
        }
        set {
            this.sourceField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.algonquincollege.com/cst8259/labs")]
public partial class restaurantsRestaurantGeneralInfoLogoDimensions {
    
    private byte[] itemsField;
    
    private ItemsChoiceType[] itemsElementNameField;
    
    private string unitField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("height", typeof(byte))]
    [System.Xml.Serialization.XmlElementAttribute("width", typeof(byte))]
    [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
    public byte[] Items {
        get {
            return this.itemsField;
        }
        set {
            this.itemsField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public ItemsChoiceType[] ItemsElementName {
        get {
            return this.itemsElementNameField;
        }
        set {
            this.itemsElementNameField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string unit {
        get {
            return this.unitField;
        }
        set {
            this.unitField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.algonquincollege.com/cst8259/labs", IncludeInSchema=false)]
public enum ItemsChoiceType {
    
    /// <remarks/>
    height,
    
    /// <remarks/>
    width,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.algonquincollege.com/cst8259/labs")]
[System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.algonquincollege.com/cst8259/labs", IsNullable=false)]
public partial class address {
    
    private string streetField;
    
    private string cityField;
    
    private state stateField;
    
    private string postalCodeField;
    
    /// <remarks/>
    public string street {
        get {
            return this.streetField;
        }
        set {
            this.streetField = value;
        }
    }
    
    /// <remarks/>
    public string city {
        get {
            return this.cityField;
        }
        set {
            this.cityField = value;
        }
    }
    
    /// <remarks/>
    public state state {
        get {
            return this.stateField;
        }
        set {
            this.stateField = value;
        }
    }
    
    /// <remarks/>
    public string postalCode {
        get {
            return this.postalCodeField;
        }
        set {
            this.postalCodeField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.algonquincollege.com/cst8259/labs")]
public enum state {
    
    /// <remarks/>
    ON,
    
    /// <remarks/>
    QC,
    
    /// <remarks/>
    BC,
    
    /// <remarks/>
    AB,
    
    /// <remarks/>
    SK,
    
    /// <remarks/>
    MB,
    
    /// <remarks/>
    NL,
    
    /// <remarks/>
    PE,
    
    /// <remarks/>
    NB,
    
    /// <remarks/>
    NS,
    
    /// <remarks/>
    NT,
    
    /// <remarks/>
    NV,
    
    /// <remarks/>
    YK,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.algonquincollege.com/cst8259/labs")]
public partial class restaurantsRestaurantGeneralInfoPhone {
    
    private ushort areaCodeField;
    
    private string numberField;
    
    /// <remarks/>
    public ushort areaCode {
        get {
            return this.areaCodeField;
        }
        set {
            this.areaCodeField = value;
        }
    }
    
    /// <remarks/>
    public string number {
        get {
            return this.numberField;
        }
        set {
            this.numberField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.algonquincollege.com/cst8259/labs")]
public partial class restaurantsRestaurantGeneralInfoRating {
    
    private byte minField;
    
    private byte maxField;
    
    private byte valueField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte min {
        get {
            return this.minField;
        }
        set {
            this.minField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte max {
        get {
            return this.maxField;
        }
        set {
            this.maxField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public byte Value {
        get {
            return this.valueField;
        }
        set {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.algonquincollege.com/cst8259/labs")]
public partial class restaurantsRestaurantGeneralInfoPriceRange {
    
    private byte minField;
    
    private byte maxField;
    
    private byte valueField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte min {
        get {
            return this.minField;
        }
        set {
            this.minField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte max {
        get {
            return this.maxField;
        }
        set {
            this.maxField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public byte Value {
        get {
            return this.valueField;
        }
        set {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.algonquincollege.com/cst8259/labs")]
public partial class restaurantsRestaurantReview {
    
    private System.DateTime dateField;
    
    private string reviewerField;
    
    private string summaryField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
    public System.DateTime date {
        get {
            return this.dateField;
        }
        set {
            this.dateField = value;
        }
    }
    
    /// <remarks/>
    public string reviewer {
        get {
            return this.reviewerField;
        }
        set {
            this.reviewerField = value;
        }
    }
    
    /// <remarks/>
    public string summary {
        get {
            return this.summaryField;
        }
        set {
            this.summaryField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.algonquincollege.com/cst8259/labs")]
public partial class restaurantsRestaurantMenuItem {
    
    private object[] itemsField;
    
    private ItemsChoiceType1[] itemsElementNameField;
    
    private string typeField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("description", typeof(string))]
    [System.Xml.Serialization.XmlElementAttribute("name", typeof(string))]
    [System.Xml.Serialization.XmlElementAttribute("price", typeof(restaurantsRestaurantMenuItemPrice))]
    [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
    public object[] Items {
        get {
            return this.itemsField;
        }
        set {
            this.itemsField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public ItemsChoiceType1[] ItemsElementName {
        get {
            return this.itemsElementNameField;
        }
        set {
            this.itemsElementNameField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string type {
        get {
            return this.typeField;
        }
        set {
            this.typeField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.algonquincollege.com/cst8259/labs")]
public partial class restaurantsRestaurantMenuItemPrice {
    
    private byte quantityField;
    
    private bool quantityFieldSpecified;
    
    private string valueField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte quantity {
        get {
            return this.quantityField;
        }
        set {
            this.quantityField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool quantitySpecified {
        get {
            return this.quantityFieldSpecified;
        }
        set {
            this.quantityFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value {
        get {
            return this.valueField;
        }
        set {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.algonquincollege.com/cst8259/labs", IncludeInSchema=false)]
public enum ItemsChoiceType1 {
    
    /// <remarks/>
    description,
    
    /// <remarks/>
    name,
    
    /// <remarks/>
    price,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.algonquincollege.com/cst8259/labs")]
[System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.algonquincollege.com/cst8259/labs", IsNullable=false)]
public partial class menuItem {
    
    private string nameField;
    
    private string descriptionField;
    
    private menuItemPrice[] priceField;
    
    private string typeField;
    
    /// <remarks/>
    public string name {
        get {
            return this.nameField;
        }
        set {
            this.nameField = value;
        }
    }
    
    /// <remarks/>
    public string description {
        get {
            return this.descriptionField;
        }
        set {
            this.descriptionField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("price")]
    public menuItemPrice[] price {
        get {
            return this.priceField;
        }
        set {
            this.priceField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string type {
        get {
            return this.typeField;
        }
        set {
            this.typeField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.algonquincollege.com/cst8259/labs")]
public partial class menuItemPrice {
    
    private uint quantityField;
    
    private bool quantityFieldSpecified;
    
    private decimal valueField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public uint quantity {
        get {
            return this.quantityField;
        }
        set {
            this.quantityField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool quantitySpecified {
        get {
            return this.quantityFieldSpecified;
        }
        set {
            this.quantityFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public decimal Value {
        get {
            return this.valueField;
        }
        set {
            this.valueField = value;
        }
    }
}
