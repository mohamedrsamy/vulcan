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

namespace VulcanEngine.IR.Ast
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1501:AvoidExcessiveInheritance")]
    [FriendlyNameAttribute("Template")]
    [AstSchemaTypeBindingAttribute("", "http://tempuri.org/vulcan2.xsd")]
    public abstract partial class AstTemplateNode : VulcanEngine.IR.Ast.AstScopeBoundaryNode
    {
        #region Private Storage
        private VulcanCollection<VulcanEngine.IR.Ast.AstTemplateArgumentNode> _arguments;

        #endregion Private Storage

        #region Public Accessor Properties
        [Browsable(false)]
        [AstXNameBinding("Argument", ChildType.ListChildDefinition)]
        public VulcanCollection<VulcanEngine.IR.Ast.AstTemplateArgumentNode> Arguments
        {
            get { return _arguments; }
        }


        #endregion Public Accessor Properties

        #region Collection Methods
        private void _arguments_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            VulcanEngine.IR.Ast.AstTemplateArgumentNode.ProcessAstNamedNodeCollectionAction(e);
            VulcanOnCollectionPropertyChanged("Arguments", e);
        }

        #endregion Collection Methods

        #region Initialization
        private void InitializeAstNode()
        {
            _arguments = new VulcanCollection<VulcanEngine.IR.Ast.AstTemplateArgumentNode>();
            _arguments.CollectionChanged += _arguments_CollectionChanged;
        }

        #endregion Initialization

        public override VulcanCollection<IFrameworkItem> DefinedAstNodes()
        {
            var definedAstNodes = new VulcanCollection<IFrameworkItem>();
            definedAstNodes.AddRange(base.DefinedAstNodes());
            foreach (var item in _arguments)
            {
                definedAstNodes.Add(item);
            }

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
            throw new NotSupportedException("Cannot clone abstract IFrameworkElement class.  You are missing a Clone method on a non-abstract derived type.");
        }

        public override IFrameworkItem Clone(Dictionary<IFrameworkItem, IFrameworkItem> cloneMapping)
        {
            throw new NotSupportedException("Cannot clone abstract IFrameworkElement class.  You are missing a Clone method on a non-abstract derived type.");
        }

        public override IFrameworkItem Clone(IFrameworkItem parentItem)
        {
            throw new NotSupportedException("Cannot clone abstract IFrameworkElement class.  You are missing a Clone method on a non-abstract derived type.");
        }

        public override IFrameworkItem Clone(IFrameworkItem parentItem, Dictionary<IFrameworkItem, IFrameworkItem> cloneMapping)
        {
            throw new NotSupportedException("Cannot clone abstract IFrameworkElement class.  You are missing a Clone method on a non-abstract derived type.");
        }

        public override void CloneInto(IFrameworkItem targetItem, Dictionary<IFrameworkItem, IFrameworkItem> cloneMapping)
        {
            base.CloneInto(targetItem, cloneMapping);
            if (targetItem == null || !typeof(AstTemplateNode).IsAssignableFrom(targetItem.GetType()))
            {
                throw new ArgumentException("Provided target node is not of the correct type.");
            }
            var castedTargetItem = (AstTemplateNode)targetItem;
            foreach (var item in _arguments)
            {
                IFrameworkItem candidate = cloneMapping[item];
                castedTargetItem._arguments.Add((VulcanEngine.IR.Ast.AstTemplateArgumentNode)candidate);
                item.CloneInto(candidate, cloneMapping);
            }

        }

        public override IFrameworkItem CloneHusk(IFrameworkItem parentItem)
        {
            throw new NotSupportedException("Cannot clone abstract IFrameworkElement class.  You are missing a Clone method on a non-abstract derived type.");
        }

        #endregion Cloning Support


    }
}