   M S B A M L   `   `   `  ����Q  MRegistrarCourseManager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:RegistrarCourseManager.ViewRegistrarCourseManager.View  5      S.clr-namespace:RegistrarCourseManager.ViewModel RegistrarCourseManager.ViewModel  5      +    %RegistrarCourseManager.View.LoginView   5      \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ;local)clr-namespace:RegistrarCourseManager.View     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      D	viewmodel.clr-namespace:RegistrarCourseManager.ViewModel     5        � 	Resources  5      ��%    54      .��57      � -   5         �Name$ mainWindowGrid��57       � ColumnDefinitions 59   
   �� 5:      $��6* �6   �� 5;      $��4* �6   .+�5>   
   �� $��2��5?      $$��../Images/login-background.png��5@      $
��Fill=�5A       J� Effect 5B      -  'System.Windows.Media.Effects.BlurEffect  5C         
KernelType$ Gaussian=�6      Radius$ 12Q�63   5E      �� 5G   
   $	��250��5H       �� BitmapScalingMode$ HighQuality=�5I      $��../Images/eku-big-e.png��5J      �� 5L   
   $��2��5M      $��1��5N         maroonBackground#��[  5O       J� Opacity$	 .94Q�5P       5Q      3  -System.Windows.Media.Effects.DropShadowEffect  5R         
BlurRadius$ 8Q�5S      	   	Direction$		 180Q�5T      
   Opacity$	
 .25Q�5U         ShadowDepth$ 4Q�5V      5X      �� 5Z   
   -   5         ��Name$ 	loginForm��5[      $��1��5\      $��Center=�5]      $��Center=�5^      .+�5_      �� $��10q�5`      $��Center=�5a      $��18(�5b      $��Light"�5c      
�������$��Login��5e      �� 5f      $	��256��5g      $	��0,5q�5h      
�������$��0,0,0,1q�5j      ._�5k      �� $��Stretch=�6   .+�5l      �� $��0q�5m      $��Stretch=�5n      ���	#00000000$��Username��5p      $��Bottom=�5q      $��12(�5r      $��Light"�5s      
�������5t      �� 5u      $��Stretch=�5v      $��Stretch=�5w      
������ $��0q�5y      $��Bottom=�5z      $��18(�5{      $��
UltraLight"�5|      
������� �� TextAlignment$
 Left=�5      ��5~      �� *
Username+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�5      5�      5�      �� 5�      $	��256��5�      $��0,10,0,0q�5�      
�������$��0,0,0,1q�5�      ._�5�      �� $��Stretch=�6   .+�5�      �� $��0q�5�      ���	#00000000$��Password��5�      $��12(�5�      $��Light"�5�      
�������5�      G� 5�      -   5        
������ $��0q�5�      $��18(�5�      $��
UltraLight"�5�      
�������5�      5�      5�      ]� 5�      $	��256��5�      $��0,30,0,0q�5�      $��Center=�5�      $��Center=�5�      .+�5�      �� $	��100��5�      $��28��5�      $��Right=�5�      $��Submit��5�       � Cursor$
 Hand��5�        RoundOutlineButton#��[ 5�      ��5�      �� *LoginCommand+5�      5�      5�      5�      5�      