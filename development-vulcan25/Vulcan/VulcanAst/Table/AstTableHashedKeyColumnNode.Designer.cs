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

namespace VulcanEngine.IR.Ast.Table
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1501:AvoidExcessiveInheritance")]
    [FriendlyNameAttribute("HashedKeyColumn")]
    [AstSchemaTypeBindingAttribute("HashedKeyColumnElemType", "http://tempuri.org/vulcan2.xsd")]
    public partial class AstTableHashedKeyColumnNode : VulcanEngine.IR.Ast.Table.AstTableColumnBaseNode
    {
        #region Private Storage
        private VulcanEngine.IR.Ast.Table.AstTableKeyBaseNode _constraint;
        private bool __isNotFirstSet__constraint;

        #endregion Private Storage

        #region Public Accessor Properties
        [VulcanCategory("Required")]
        [AstRequiredProperty]
        [VulcanDescription(@"Specifies referenced constraint name.")]
        [Browsable(true)]
        [AstXNameBinding("ConstraintName", ChildType.Attribute)]
        public VulcanEngine.IR.Ast.Table.AstTableKeyBaseNode Constraint
        {
            get { return _constraint; }
            set
            {
                if (_constraint != value || !__isNotFirstSet__constraint)
                {
                    __isNotFirstSet__constraint = true;
                    if (_constraint != null)
                    {
                        _constraint.Unreference(this, "Constraint");
                    }
                    VulcanEngine.IR.Ast.Table.AstTableKeyBaseNode oldValue = _constraint;
                    _constraint = value;
                    if (_constraint != null)
                    {
                        _constraint.Reference(this, "Constraint");
                    }
                    VulcanOnPropertyChanged("Constraint", oldValue, _constraint);
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
            if (targetItem == null || !typeof(AstTableHashedKeyColumnNode).IsAssignableFrom(targetItem.GetType()))
            {
                throw new ArgumentException("Provided target node is not of the correct type.");
            }
            var castedTargetItem = (AstTableHashedKeyColumnNode)targetItem;
            if (_constraint == null)
            {
                castedTargetItem._constraint = null;
            }
            else if (cloneMapping.ContainsKey(_constraint))
            {
                castedTargetItem._constraint = (VulcanEngine.IR.Ast.Table.AstTableKeyBaseNode)cloneMapping[_constraint];
            }
            else
            {
                castedTargetItem._constraint = _constraint;
            }

        }

        public override IFrameworkItem CloneHusk(IFrameworkItem parentItem)
        {
            return new AstTableHashedKeyColumnNode(parentItem);
        }

        #endregion Cloning Support


    }
}