   M S B A M L   `   `   `  ����N  JAgentAssignmentLab1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:AgentAssignmentLab1AgentAssignmentLab1  5   	   $    AgentAssignmentLab1.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:AgentAssignmentLab1     5   	     � Title$!  Agent Assignments 1 - Lab 1��5   	   $	��450��6-   $	��800��6:   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $
��264* �6   6.   �� 5      $
��221* �6   6.   .+�5   
   �� -   5        $��label1��5   -   $��28��6   $��0,8,0,0q�6   $	��Top=�6;   $
��Left=�6S   .��6o   Id6s   �� 5   
   -   5        $��label2��5   .   $��28��6   $��0,37,0,0q�6   $	��Top=�6<   $
��Left=�6T   .��6p   
CodeName6z   �� 5   
   -   5        $��label3��5   .   $��28��6   $��0,72,0,0q�6   $	��Top=�6<   $
��Left=�6T   .��6p   
Speciality6|   �� 5   
   -   5        $��label4��5   /   $��28��6   $��	0,107,0,0q�6   $	��Top=�6=   $
��Left=�6U   .��6q   
Assignment6}   �� 5   
   -   5        $��textBox1��5      $��23��5      $��
100,10,0,0q�5      $	��Top=�5      $
��Left=�5      $��58��5      ��5      ��  �� Path$ ID��� 5   
   -   5        $��textBox2��5   3   $��23��6   $��100,39,14,0q�6   $	��Top=�5      ��6.   �� $ CodeName��� 5   
   -   5        $��textBox3��5   3   $��23��6   $��100,72,14,0q�6   $	��Top=�6C   ��5      �� $ 
Speciality��� 5   
   -   5        $��textBox4��5      $��100,109,14,0q�5      $��82��5        �� AcceptsReturn .  �� TextWrapping$
 Wrap=�5"      $	��Top=�5#      ��5      �� $ 
Assignment�5#      �� 5$   
   -	   5        $
��tbId��5$   B   $��1��6   $��21��6$   $��19,8,0,0q�60   $	��Top=�6N   $
��Left=�6f   $��54��6�   ��5%      �� $ ID��� 5&   
   -
   5        $��
tbCodeName��5&   C   $��1��6   $��21��6$   $��	19,37,0,0q�60   $	��Top=�6U   $
��Left=�6m   $	��100��6�   ��5'      �� $ CodeName��� 5(   
   -   5        $��tbSpeciality��5(   E   $��1��6   $��21��6$   $��19,74,102,0q�60   $	��Top=�6Y   ��6q   �� $ 
Speciality��� 5)   
   -   5        $��tbAssignment��5)   G   $��1��6   $��21��6$   $��
19,112,0,0q�63   $	��Top=�6[   ��6s   �� $ 
Assignment�5*      5+      