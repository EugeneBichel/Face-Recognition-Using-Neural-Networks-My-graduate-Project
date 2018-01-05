using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Animation;
using Microsoft.Practices.EnterpriseLibrary.ExceptionHandling;

namespace BusyControl
{
    public partial class BluBusyControl : UserControl
    {
        #region Fields

        private Storyboard _rotateStoryBoard;
        private TransformGroup group;
        private RotateTransform rotate;

        #endregion //Fields

        #region Dependency Properties

        public static readonly DependencyProperty FullNameImageProperty;

        #endregion //Dependency Properties

        #region Constructor

        static BluBusyControl()
        {
            FullNameImageProperty = DependencyProperty.Register("FullNameImage",
                                                                typeof (string),
                                                                typeof (BluBusyControl),
                                                                new PropertyMetadata(string.Empty));
        }

        public BluBusyControl()
        {
            this.DataContext = this;

            _rotateStoryBoard = new Storyboard();
            
            InitializeComponent();

            NameScope.SetNameScope(this, new NameScope());
            this.RenderTransformOrigin = new Point(.5, .5);

            group = new TransformGroup();
            rotate = new RotateTransform(0);

            group.Children.Add(rotate);
            this.RegisterName("rotate", rotate);
            this.RegisterName(imageSource.Name, this);
            this.RenderTransform = group;

            var timeSpan = TimeSpan.FromSeconds(3);
            var d = new DoubleAnimation();
            d.From = 360;
            d.To = 0;
            d.Duration = new Duration(timeSpan);
            _rotateStoryBoard.Children.Add(d);

            Storyboard.SetTargetName(d, "rotate");
            Storyboard.SetTargetProperty(d, new PropertyPath(RotateTransform.AngleProperty));

            _rotateStoryBoard.RepeatBehavior = RepeatBehavior.Forever;
            Loaded += BusyControl_Loaded;
        }

        #endregion //Constructor

        #region Wrappers for Dependency Properties

        public string FullNameImage
        {
            get { return (string)GetValue(FullNameImageProperty); }
            set { SetValue(FullNameImageProperty, value); }
        }

        #endregion //Wrappers for Dependency Properties

        #region Handlers

        private void BusyControl_Loaded(object sender, RoutedEventArgs e)
        {
            _rotateStoryBoard.Begin(this);
        }

        #endregion //Handlers
    }
}
