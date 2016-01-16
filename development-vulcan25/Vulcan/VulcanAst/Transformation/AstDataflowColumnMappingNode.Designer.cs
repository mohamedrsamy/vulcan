//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by the Varigence Ast Designer tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.  Do not edit this file unless you know exactly
//     you are doing and are synchronized with the Vulcan development team.
//
//     For more information about the Varigence Ast Designer tool, email
//     support@varigence.com.
//
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Collections.Specialized;
using Vulcan.Utility.ComponentModel;
using AstFramework;
using AstFramework.Engine.Binding;
using AstFramework.Model;
using AstFramework.Markup;
using VulcanEngine.AstFramework;
using Vulcan.Utility.Collections;
using System.Reflection;
using System.Collections.Generic;
using Vulcan.Utility.Xml;
using Vulcan.Utility.Common;
using Vulcan.Utility.Markup;

namespace VulcanEngine.IR.Ast.Transformation
{
    [AstSchemaTypeBindingAttribute("GlobalColumnMapElemType", "http://tempuri.org/vulcan2.xsd")]
    public partial class AstDataflowColumnMappingNode : VulcanEngine.IR.Ast.AstNode
    {
        #region Private Storage
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")]
        protected System.String SourceName_BackingField;
        private bool __isNotFirstSet_SourceName_BackingField;
        private bool _isSourceNameExplicitlySet;

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")]
        protected System.String TargetName_BackingField;
        private bool _isTargetNameExplicitlySet;

        #endregion Private Storage

        #region Public Accessor Properties
        [VulcanCategory("Required")]
        [AstRequiredProperty]
        [VulcanDescription(@"")]
        [Browsable(true)]
        [AstXNameBinding("SourceName", ChildType.Attribute)]
        public System.String SourceName
        {
            get { return SourceName_BackingField; }
            set
            {
                if (SourceName_BackingField != value || !__isNotFirstSet_SourceName_BackingField)
                {
                    __isNotFirstSet_SourceName_BackingField = true;
                    System.String oldValue = SourceName_BackingField;
                    SourceName_BackingField = value;
                    VulcanOnPropertyChanged("SourceName", oldValue, SourceName_BackingField);
                    IsSourceNameExplicitlySet = true;
                }
            }
        }

        public bool IsSourceNameExplicitlySet
        {
            get { return _isSourceNameExplicitlySet; }
            protected set
            {
                if (_isSourceNameExplicitlySet != value)
                {
                    bool oldValue = _isSourceNameExplicitlySet;
                    _isSourceNameExplicitlySet = value;
                    VulcanOnPropertyChanged("IsSourceNameExplicitlySet", oldValue, _isSourceNameExplicitlySet);
                }
            }
        }


        [VulcanCategory("Optional")]
        [VulcanDescription(@"")]
        [Browsable(true)]
        [AstXNameBinding("TargetName", ChildType.Attribute)]
        public System.String TargetName
        {
            get { return TargetName_BackingField; }
            set
            {
                if (TargetName_BackingField != value)
                {
                    System.String oldValue = TargetName_BackingField;
                    TargetName_BackingField = value;
                    VulcanOnPropertyChanged("TargetName", oldValue, TargetName_BackingField);
                    IsTargetNameExplicitlySet = true;
                }
            }
        }

        public bool IsTargetNameExplicitlySet
        {
            get { return _isTargetNameExplicitlySet; }
            protected set
            {
                if (_isTargetNameExplicitlySet != value)
                {
                    bool oldValue = _isTargetNameExplicitlySet;
                    _isTargetNameExplicitlySet = value;
                    VulcanOnPropertyChanged("IsTargetNameExplicitlySet", oldValue, _isTargetNameExplicitlySet);
                }
            }
        }


        #endregion Public Accessor Properties

        #region Collection Methods


        #endregion Collection Methods

        #region Initialization
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic")]
        private void InitializeAstNode()
        {
        }

        #endregion Initialization

        public override VulcanCollection<IFrameworkItem> DefinedAstNodes()
        {
            var definedAstNodes = new VulcanCollection<IFrameworkItem>();
            definedAstNodes.AddRange(base.DefinedAstNodes());


            return definedAstNodes;
        }


        public override IEnumerable<IScopeBoundary> BindingScopeBoundaries()
        {
            var bindingScopeBoundaries = new List<IScopeBoundary>();
            bindingScopeBoundaries.Add(ScopeBoundary);
            return bindingScopeBoundaries;
        }


        #region Cloning Support
        public override IFrameworkItem Clone()
        {
            return Clone(ParentItem);
        }

        public override IFrameworkItem Clone(Dictionary<IFrameworkItem, IFrameworkItem> cloneMapping)
        {
            return Clone(ParentItem, cloneMapping);
        }

        public override IFrameworkItem Clone(IFrameworkItem parentItem)
        {
            return Clone(parentItem, new Dictionary<IFrameworkItem, IFrameworkItem>());
        }

        public override IFrameworkItem Clone(IFrameworkItem parentItem, Dictionary<IFrameworkItem, IFrameworkItem> cloneMapping)
        {
            SymbolTable.GetSourceToCloneDefinitionMappings(this, parentItem, cloneMapping);
            CloneInto(cloneMapping[this], cloneMapping);
            return cloneMapping[this];
        }

        public override void CloneInto(IFrameworkItem targetItem, Dictionary<IFrameworkItem, IFrameworkItem> cloneMapping)
        {
            base.CloneInto(targetItem, cloneMapping);
            if (targetItem == null || !typeof(AstDataflowColumnMappingNode).IsAssignableFrom(targetItem.GetType()))
            {
                throw new ArgumentException("Provided target node is not of the correct type.");
            }
            var castedTargetItem = (AstDataflowColumnMappingNode)targetItem;
            castedTargetItem.SourceName_BackingField = SourceName_BackingField;

            castedTargetItem.TargetName_BackingField = TargetName_BackingField;

        }

        public override IFrameworkItem CloneHusk(IFrameworkItem parentItem)
        {
            return new AstDataflowColumnMappingNode(parentItem);
        }

        #endregion Cloning Support


    }
}