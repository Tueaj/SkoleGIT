   M S B A M L   `   `   `  ����?  ;Lab2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:Lab2Lab2  5   	       Lab2.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   $localclr-namespace:Lab2     5   	     � Title$!  Agent Assignments 1 - Lab 2��5   	   $	��450��6-   $	��800��6:   .��5	      � -   5        $��	agentGrid��5	       � ColumnDefinitions 5
   
   �� 5      $
��264* �6   6.   �� 5      $
��221* �6   6.   .+�5   
   �� -   5        $��label1��5   -   $��28��6   $��0,8,0,0q�6   $	��Top=�6;   $
��Left=�6S   .��6o   Id6s   �� 5   
   -   5        $��label2��5   .   $��28��6   $��0,37,0,0q�6   $	��Top=�6<   $
��Left=�6T   .��6p   
CodeName6z   �� 5   
   -   5        $��label3��5   .   $��28��6   $��0,72,0,0q�6   $	��Top=�6<   $
��Left=�6T   .��6p   
Speciality6|   �� 5   
   -   5        $��label4��5   /   $��28��6   $��	0,107,0,0q�6   $	��Top=�6=   $
��Left=�6U   .��6q   
Assignment6}   �� 5   
   -   5        $��textBox1��5      $��23��5      $��
100,10,0,0q�5      $	��Top=�5      $
��Left=�5      $��58��5      ��5      ��  �� Path$ ID��� 5   
   -   5        $��textBox2��5   3   $��23��6   $��100,39,14,0q�6   $	��Top=�5      ��6.   �� $ CodeName��� 5   
   -   5        $��textBox3��5   3   $��23��6   $��100,72,14,0q�6   $	��Top=�6C   ��5      �� $ 
Speciality��� 5   
   -	   5        $��textBox4��5      $��100,109,14,0q�5      $��82��5        �� AcceptsReturn .  �� TextWrapping$
 Wrap=�5"      $	��Top=�5#      ��5      �� $ 
Assignment�5#      �� 5%   
   -
   5        $��	lbxAgents��5(      $ �� IsSynchronizedWithCurrentItem$
 TrueY�5&       �� DisplayMemberPath$ CodeName��5'      $��1��5)      $��9q�5*      ��5%      �� 5*      5,      5-      