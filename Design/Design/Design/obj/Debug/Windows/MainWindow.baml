   M S B A M L   `   `   `  ����A  =Design, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:Design.WindowsDesign.Windows  5   	   'clr-namespace:Design.UCs
Design.UCs  5   	       Design.Windows.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:Design.Windows     5   	   ,localUCclr-namespace:Design.UCs     5   	     � Title$  
MainWindow��5	   	   $	��450��6   $	��800��6)   $	��490��5
   	   $	��820��6   .��5      � -   5         �Name$ 	firstGrid��5       � RowDefinitions 5   
   �� 5      $��50 �6   �� 5      �� 5      $��26 �6   .+�5   
   �� -   5         ��Name$ Header��5         NBABlue#��[  6!   $��0,0,0,1q�6H   ._�5      � -   5        $
 Head��5      .+�5      ��  �� Orientation$ 
Horizontal=�6   .+�5      �� $��../Assets/logo.jpg��6   ��68   ��  �� ElementName$
 Head�� �� Path$ ActualHeight��� 5      $��NBA Management System��6   $��Center=�6<   5      �� 5      -   5         ��Name$ headerLabel��5      $��Admin Login��5      $��Center=�5      $��Center=�65   �� 5      -   5         ��Name$ 
backButton��5      $
��Back��6-   $��Right=�5      $��20��5      $��50��6%   $��10q�5      5      5      5          Design.UCs.MainUC  5!   
   -   5        	  Name$	 mainUC��5!         Design.UCs.MainUC
   IsVisibleChanged$
 mainUC_IsVisibleChanged��6G   $��0��6)   $��2��66   6G      Design.UCs.VisitorUC  5"   
   -   5          Name$ 	visitorUC��5"      $��0��6/   $��1��6?   $y�	Collapsed=�6L      Design.UCs.TeamsMainUC  5#   
   -   5          Name$ teamsMainUC��5#      $��1��63   $y�	Collapsed=�6@   �� 5$   
   -	   5        $ Footer��5$      $��2��5%      $U��OThe current season is 2016-2017, and the NBA already has a history of 71 years.��6   $��Center=�5&      $��Center=�64   #��[  5'      
�������66   5(      5)      