   M S B A M L   `   `   `  ����Q  MRegistrarCourseManager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:RegistrarCourseManager.ViewRegistrarCourseManager.View  5      _4clr-namespace:RegistrarCourseManager.ViewModel.Popup&RegistrarCourseManager.ViewModel.Popup  5      _4clr-namespace:RegistrarCourseManager.ViewModel.Popup&RegistrarCourseManager.ViewModel.Popup  5	      -    'RegistrarCourseManager.View.PopupWindow   5      \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ;local)clr-namespace:RegistrarCourseManager.View     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      J	popupView4clr-namespace:RegistrarCourseManager.ViewModel.Popup     5      OpopupViewmodel4clr-namespace:RegistrarCourseManager.ViewModel.Popup     5	        � Title$  PopupWindow��5
       � AllowsTransparency$
 True��5      
������ $��0q�5       � Topmost$
 True��5       � WindowStartupLocation$ CenterScreen=�5       � WindowStyle$
 None=�5       � 	Resources 5      ��%    5      .��5      �� $	��260��5   	   $	��290��5   	   $��10q�5   	   
�������$��0q�5   	    �� CornerRadius$ 7��5    	    J� Effect 5!   
   3  -System.Windows.Media.Effects.DropShadowEffect  5"         
BlurRadius$ 6Q�5#      	   	Direction$		 -90Q�5$      
   Opacity$	
 .25Q�5%      ._�5'   
   � 
������  � RowDefinitions 5(      �� 5)      $��1* �6    �� 5*      $��3* �6    .+�5-      �� -   5           maroonBackground#��[  5/      #��[  50      $��0q�51      $ 7 7 0 0��52       53        54      $ 5Q�55      $		 270Q�56      $	
 .25Q�57         ShadowDepth$ 3Q�58      ._�5<      �� $��0��5=      $��Center=�5>      $��Center=�5?       �� Orientation$ 
Horizontal=�5@      .+�5A      �� $��20��5B       �� BitmapScalingMode$ HighQuality=�5C      ��5D      �� *
IconSource+�� 5E      $��17(�5G      $��Light"�5H      
���������5F      �� *Title+5I      5J      5K      �� 5M      $��1��6   ��6,   �� *	PopupView+5O      5Q      5R      