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
    public class TabButton : Control
    {

        public Brush SelectedBrush
        {
            get
            {
                return Application.Current.Resources["secondaryColor"] as SolidColorBrush;
            }
        }

        public Brush UnselectedBrush
        {
            get
            {
                return Application.Current.Resources["maroonBackground"] as SolidColorBrush;
            }
        }

        static TabButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(TabButton), new FrameworkPropertyMetadata(typeof(TabButton)));
        }

        // Using a DependencyProperty as the backing store for Selected.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SelectedProperty = 
            DependencyProperty.Register("Selected", typeof(bool), typeof(TabButton), new FrameworkPropertyMetadata(defaultValue: false, propertyChangedCallback: new PropertyChangedCallback(OnSelectedChanged)));
        public static readonly DependencyProperty IconPathProperty = 
            DependencyProperty.Register("IconPath", typeof(string), typeof(TabButton), new PropertyMetadata("../Images/plus-circle.png"));
        public static readonly DependencyProperty TitleProperty = 
            DependencyProperty.Register("Title", typeof(string), typeof(TabButton), new PropertyMetadata("test"));
        public static readonly DependencyProperty CommandProperty = 
            DependencyProperty.Register("Command", typeof(BaseCommand), typeof(TabButton), new PropertyMetadata(new BaseCommand(null)));
        // https://stackoverflow.com/questions/2480366/how-to-raise-property-changed-events-on-a-dependency-property


        private static void OnSelectedChanged(DependencyObject depObj, DependencyPropertyChangedEventArgs e)
        {
            TabButton tabButton = depObj as TabButton;

            UpdateTabButtonState(tabButton);
        }

        private static void UpdateTabButtonState(TabButton tabButton)
        {
            if (tabButton.Selected)
            {
                VisualStateManager.GoToState(tabButton, "Selected", false);
            }
            else
            {
                VisualStateManager.GoToState(tabButton, "Unselected", false);
            }
        }

        public BaseCommand Command
        {
            get { return (BaseCommand)GetValue(CommandProperty); }
            set { SetValue(CommandProperty, value); }
        }

        public bool Selected
        {
            get { return (bool)GetValue(SelectedProperty); }
            set { SetValue(SelectedProperty, value); }
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
        }

        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();


            UpdateTabButtonState(this);

            var tabButton = GetTemplateChild("Grid_TabButton") as Grid;
            if (tabButton != null)
                tabButton.MouseDown += Button_Click;
        }
    }
}
