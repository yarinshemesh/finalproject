   M S B A M L   `   `   `  ����K  GMovieLandByYarin, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:MovieLandByYarinMovieLandByYarin  5   	   #    MovieLandByYarin.AddOrderFood   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:MovieLandByYarin     5   	   -   5          � Title$  contactAdder��5      $	��500��6   $	��500��6)   
�������.��5	      �  � ColumnDefinitions 5
   
   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6    � RowDefinitions 5   
   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   .+�5   
   �� $��	COSTUMER:��6   $
��Left=�6&   $	��Top=�6A   $��18,10.333,0,0q�6Y   $��1��6p   $��2��6}   $	��116��6�   $��Century Schoolbook)�6�   �� 5   
   $��WORKER:��6   $��2��6$   $	��116��68   $��Century Schoolbook)�6E   $��14,42,67.333,38.667q�6e   �� 5   
   -   5         ��Name$ workers_list��5       �� DisplayMemberPath$
 Name��6)    �� SelectedValuePath$ Id��6B   $��2��6{   $
��Left=�6�   $��24��6�   $	��Top=�6�   $	��120��6�   $��	14,71,0,0q�6�   $��2��6�    �� SelectedValue 6Z   �� *Worker+6�   �� 5   
   -   5        $ cos_list��5      $
 Name��6%   $ Id��6>   $��2��6y   $
��Left=�6�   $��24��6�   $	��Top=�6�   $	��120��6�   $��18,36.333,0,0q�6�   $��1��6�    6V   �� *
Costumer+6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dataGrid��5   �   $
��Left=�6   $	��187��6.   $	��Top=�6;   $	��314��6S   $��14,60.333,0,0q�6_   $��3��6v   $��2��6�   $��4��6�   �� 5   
   -   5        $��ADD details��5      $
��Left=�6'   $	��Top=�6B   $��75��6Z   $��2��6e   $��3��6y   $��55,0.333,0,0q�6�   $��3��6�   $��30��6�   6�   �� 5   
   -   5        $��save changes��5      $
��Left=�6(   $	��Top=�6C   $��75��6[   $��3��6f   $��80,59.333,0,0q�6v   $��3��6�   $��60��6�   $��2��6�   $��2��6�   �� 5    
   -   5         ��Name$ txtSum��5       $��0��6$   $	��Top=�6-   $��55,31,13.333,0q�6E   $��2��6]   $��37��6q   $��Century Schoolbook)�6}   $��3��6�   5%      5&      