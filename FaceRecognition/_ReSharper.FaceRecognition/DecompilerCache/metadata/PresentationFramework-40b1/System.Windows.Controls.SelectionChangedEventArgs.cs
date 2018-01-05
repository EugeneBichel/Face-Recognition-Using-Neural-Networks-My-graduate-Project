// Type: System.Windows.Controls.SelectionChangedEventArgs
// Assembly: PresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// Assembly location: C:\Program Files\Reference Assemblies\Microsoft\Framework\.NETFramework\v4.0\PresentationFramework.dll

using System;
using System.Collections;
using System.Runtime;
using System.Windows;

namespace System.Windows.Controls
{
    public class SelectionChangedEventArgs : RoutedEventArgs
    {
        public SelectionChangedEventArgs(RoutedEvent id, IList removedItems, IList addedItems);

        public IList RemovedItems { [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
        get; }

        public IList AddedItems { [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
        get; }

        protected override void InvokeEventHandler(Delegate genericHandler, object genericTarget);
    }
}
