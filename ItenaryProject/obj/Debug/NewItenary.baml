   M S B A M L   `   `   `  ����I  EItenaryProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:ItenaryProjectItenaryProject  5   	       ItenaryProject.NewItenary   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:ItenaryProject     5   	   -   5          � Title$  
NewItenary��5   	   $	��450��6   $	��800��6)   .��5	      � 
���W�.� � RowDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      �� 5      �� 5       � ColumnDefinitions 5   
   �� 5      $	��200 �6   �� 5      .+�5   
   �� $��0��6   $��0��6"   $
��Wrap=�62    J� RenderTransformOrigin$ 0.446,-0.735&�6F   $
��Left=�6k   $��Center=�6�   �� 6�   $�Id��6�   �� 6�   �� 6�   6�   �� 5   
   -   5         ��Name$ txtId��5      $��0��6C   $��1��6P    �� TextWrapping$
 Wrap=�6`   $
��Left=�6u   $��36��6�   $��Bottom=�6�   $��0,0,0,36q�6�   $	��273��6�   ��6"   �� *NewItenary.Id+6�   �� 5   
   $��1��6   $��0��6"   $
��Wrap=�62   $ 0.446,-0.735&�6F   $
��Left=�6k   $��Center=�6�   �� 6�   $
�Time��6�   �� 6�   �� 6�   6�   �� 5   
   -   5        $ txtTime��5      $��1��6E   $
 Wrap=�6U   $
��Left=�6j   $	��Top=�6�   $��37��6�   $��0,72,0,0q�6�   $��2��6�   $	��273��6�   ��6$   �� *NewItenary.Name+6�   �� 5   
   $��2��6   $��0��6"   $
��Wrap=�62   $��Itenary��6F   $ 0.481,-0.029&�6V   $
��Left=�6{   $	��Top=�6�   �� 5   
   -   5        $ 
txtItenary��5      $��2��6P   $��1��6]   $
 Wrap=�6m   $
��Left=�6�   $	��Top=�6�   $��36��6�   $	��273��6�   ��6'   �� *NewItenary.ItenaryName+6�   �� 5   
   $��3��6   $��0��6"   $
��Wrap=�63   $��About��6G   $
��Left=�6T   $	��Top=�6o   �� 5   
   -   5        $ txtAbout��5      $��2��6H   $��1��6U   $
 Wrap=�6e   $
��Left=�6z   $	��Top=�6�   $��42��6�   $��0,72,0,0q�6�   $��2��6�   $	��273��6�   ��6%   �� *NewItenary.About+6�   �� 5    
   $��4��6   $��0��6"   $
��Wrap=�62   $��Price��6F   $
��Left=�6S   $	��Top=�6n   �� 5!   
   -   5        $ txtPrice��5!      $��3��6G   $��1��6T   $
 Wrap=�6d   $
��Left=�6y   $	��Top=�6�   $��37��6�   $��0,72,0,0q�6�   $��2��6�   $	��273��6�   ��6%   �� *NewItenary.Price+6�   �� 5"   
   $��Create Itenary��6   $��5��6M   $��0��6Z   $ 0.543,1.129&�6k   $
��Left=�6�   $��24��6�   $��Center=�6�   $	��142��6�   ��6*   �� *CreateCommand+6�   5%      5&      