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

namespace VulcanEngine.IR.Ast.Task
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1501:AvoidExcessiveInheritance")]
    [FriendlyNameAttribute("TaskEventHandler")]
    [AstSchemaTypeBindingAttribute("TaskEventHandlerElemType", "http://tempuri.org/vulcan2.xsd")]
    public partial class AstTaskEventHandlerNode : VulcanEngine.IR.Ast.Task.AstContainerTaskBaseNode
    {
        #region Private Storage
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")]
        protected VulcanEngine.IR.Ast.Task.EventType EventType_BackingField;
        private bool __isNotFirstSet_EventType_BackingField;
        private bool _isEventTypeExplicitlySet;

        #endregion Private Storage

        #region Public Accessor Properties
        [VulcanCategory("Required")]
        [AstRequiredProperty]
        [Browsable(true)]
        [AstXNameBinding("EventType", ChildType.Attribute)]
        public VulcanEngine.IR.Ast.Task.EventType EventType
        {
            get { return EventType_BackingField; }
            set
            {
                if (EventType_BackingField != value || !__isNotFirstSet_EventType_BackingField)
                {
                    __isNotFirstSet_EventType_BackingField = true;
                    VulcanEngine.IR.Ast.Task.EventType oldValue = EventType_BackingField;
                    EventType_BackingField = value;
                    VulcanOnPropertyChanged("EventType", oldValue, EventType_BackingField);
                    IsEventTypeExplicitlySet = true;
                }
            }
        }

        public bool IsEventTypeExplicitlySet
        {
            get { return _isEventTypeExplicitlySet; }
            protected set
            {
                if (_isEventTypeExplicitlySet != value)
                {
                    bool oldValue = _isEventTypeExplicitlySet;
                    _isEventTypeExplicitlySet = value;
                    VulcanOnPropertyChanged("IsEventTypeExplicitlySet", oldValue, _isEventTypeExplicitlySet);
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
            if (targetItem == null || !typeof(AstTaskEventHandlerNode).IsAssignableFrom(targetItem.GetType()))
            {
                throw new ArgumentException("Provided target node is not of the correct type.");
            }
            var castedTargetItem = (AstTaskEventHandlerNode)targetItem;
            castedTargetItem.EventType_BackingField = EventType_BackingField;

        }

        public override IFrameworkItem CloneHusk(IFrameworkItem parentItem)
        {
            return new AstTaskEventHandlerNode(parentItem);
        }

        #endregion Cloning Support


    }
}