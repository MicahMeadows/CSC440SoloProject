   M S B A M L   `   `   `  ����Q  MRegistrarCourseManager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:RegistrarCourseManagerRegistrarCourseManager  5      I)clr-namespace:RegistrarCourseManager.ViewRegistrarCourseManager.View  5      S.clr-namespace:RegistrarCourseManager.ViewModel RegistrarCourseManager.ViewModel  5	      '    !RegistrarCourseManager.MainWindow   5      \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      6local$clr-namespace:RegistrarCourseManager     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      :view)clr-namespace:RegistrarCourseManager.View     5      E
viewmodels.clr-namespace:RegistrarCourseManager.ViewModel     5	        � Title$  
MainWindow��5
      $
��1000��5      $	��600��5      $	��800��5      $	��480��5       � AllowsTransparency$
 True��5       � 
ResizeMode$ CanResizeWithGrip=�5       � WindowStartupLocation$ CenterScreen=�5       � WindowStyle$
 None=�5       � 	Resources 5       �� DataType5  /RegistrarCourseManager.ViewModel.LoginViewModel+   %RegistrarCourseManager.View.LoginView4  .RegistrarCourseManager.ViewModel.TabsViewModel*   $RegistrarCourseManager.View.TabsView��%�   (��       5      *, +)(�� 2     5      *, +)�� 5   
   "  6   .R�5        5      �� 5   
   "  6   .R�5        5      5       � DataContext 5      4  .RegistrarCourseManager.ViewModel.MainViewModel  5   
   .��5      �  � RowDefinitions 5    
   �� 5!      $��30 �6   �� 5"      $��* �6   .+�5$   
   �� -   5        $��0��5%      $��0,0,80,0q�5&      $��Stretch=�5'      $��Stretch=�5(      	 K� ZIndex$	 1��5)      
������ 5+      �� 5,   
   $��2��6   ��6*   �� *CurrentScreenViewModel+5-      5.      