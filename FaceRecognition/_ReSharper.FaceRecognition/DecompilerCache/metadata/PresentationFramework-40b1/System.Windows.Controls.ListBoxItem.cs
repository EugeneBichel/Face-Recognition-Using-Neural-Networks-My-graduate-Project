// Type: System.Windows.Controls.ListBoxItem
// Assembly: PresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// Assembly location: C:\Program Files\Reference Assemblies\Microsoft\Framework\.NETFramework\v4.0\PresentationFramework.dll

using System.ComponentModel;
using System.Runtime;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Input;

namespace System.Windows.Controls
{
    [DefaultEvent("Selected")]
    public class ListBoxItem : ContentControl
    {
        public static readonly DependencyProperty IsSelectedProperty;
        public static readonly RoutedEvent SelectedEvent;
        public static readonly RoutedEvent UnselectedEvent;

        [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
        public ListBoxItem();

        [Category("Appearance")]
        [Bindable(true)]
        public bool IsSelected { get; set; }

        [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
        protected virtual void OnSelected(RoutedEventArgs e);

        [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
        protected virtual void OnUnselected(RoutedEventArgs e);

        protected override AutomationPeer OnCreateAutomationPeer();
        protected override void OnMouseLeftButtonDown(MouseButtonEventArgs e);
        protected override void OnMouseRightButtonDown(MouseButtonEventArgs e);
        protected override void OnMouseEnter(MouseEventArgs e);
        protected override void OnMouseLeave(MouseEventArgs e);
        protected internal override void OnVisualParentChanged(DependencyObject oldParent);

        public event RoutedEventHandler Selected;
        public event RoutedEventHandler Unselected;
    }
}
