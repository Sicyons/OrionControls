using System;
using System.Windows;
using System.Windows.Controls;

namespace OrionControls
{
    /// <summary>
    /// Logique d'interaction pour OrionButton.xaml
    /// </summary>
    public partial class OrionButton : Button
    {
        #region Dependency properties
        public static readonly DependencyProperty ShadowDepthProperty = DependencyProperty.Register("ShadowDepth", typeof(Int32), typeof(OrionButton), new FrameworkPropertyMetadata(10));
        public static readonly DependencyProperty BackgroundTypeProperty = DependencyProperty.Register("TypeFond", typeof(Backgroundtypes), typeof(OrionButton), new FrameworkPropertyMetadata(Backgroundtypes.None));

        public Int32 ShadowDepth
        {
            get { return (Int32)GetValue(ShadowDepthProperty); }
            set { SetValue(ShadowDepthProperty, value); }
        }
        public Backgroundtypes BackgroundType
        {
            get { return (Backgroundtypes)GetValue(BackgroundTypeProperty); }
            set { SetValue(BackgroundTypeProperty, value); }
        }
        #endregion

        #region Constructors
        public OrionButton()
        {
            InitializeComponent();
        }// OrionButton()
        #endregion
    }
}