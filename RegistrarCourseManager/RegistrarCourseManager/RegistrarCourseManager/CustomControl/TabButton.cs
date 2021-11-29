using RegistrarCourseManager.Commands;
using RegistrarCourseManager.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Media;

namespace RegistrarCourseManager.CustomControl
{
    public class TabButton : Control, INotifyPropertyChanged
    {
        void OnPropertyChanged(string prop)
        {
            PropertyChangedEventHandler handler = PropertyChanged;

            if (handler != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;

        private double shadowOpacity = .25;
        public double ShadowOpacity
        {
            get
            {
                return (Selected == true) ? shadowOpacity : 0;
            }
        }

        public Brush BackgroundBrush
        {
            get
            {
                return (Selected == true) ? Application.Current.Resources["secondaryColor"] as SolidColorBrush : Application.Current.Resources["maroonBackground"] as SolidColorBrush;
            }
        }

        static TabButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(TabButton), new FrameworkPropertyMetadata(typeof(TabButton)));
        }

        // Using a DependencyProperty as the backing store for Selected.  This enables animation, styling, binding, etc...

        public static readonly DependencyProperty SelectedProperty = DependencyProperty.Register("Selected", typeof(bool), typeof(TabButton), new FrameworkPropertyMetadata(false, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
        public static readonly DependencyProperty IconPathProperty = DependencyProperty.Register("IconPath", typeof(string), typeof(TabButton), new PropertyMetadata("../Images/plus-circle.png"));
        public static readonly DependencyProperty TitleProperty = DependencyProperty.Register("Title", typeof(string), typeof(TabButton), new PropertyMetadata("test"));
        public static readonly DependencyProperty CommandProperty = DependencyProperty.Register("Command", typeof(BaseCommand), typeof(TabButton), new PropertyMetadata(new BaseCommand(null)));


        public BaseCommand Command
        {
            get { return (BaseCommand)GetValue(CommandProperty); }
            set { SetValue(CommandProperty, value); }
        }

        public bool Selected
        {
            get { return (bool)GetValue(SelectedProperty); }
            set { 
                SetValue(SelectedProperty, value);
                OnPropertyChanged("Selected");
            }
        }

        public string IconPath
        {
            get { return (string)GetValue(IconPathProperty); }
            set { SetValue(IconPathProperty, value); }
        }

        public string Title
        {
            get { return (string)GetValue(TitleProperty); }
            set { SetValue(TitleProperty, value); }
        }

        void Button_Click(object sender, RoutedEventArgs e)
        {
            Command.Execute(null);
            OnPropertyChanged("Selected");
        }

        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();

            var tabButton = GetTemplateChild("Grid_TabButton") as Grid;
            if (tabButton != null)
                tabButton.MouseDown += Button_Click;
        }
    }
}
