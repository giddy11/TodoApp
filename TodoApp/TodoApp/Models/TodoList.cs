using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoApp.Models
{
    public class TodoList
    {
        public string Task { get; set; }
    }
}


/*
 <ListBox.ItemTemplate>
                <DataTemplate>
                    <StackPanel>
                        <TextBlock Text="{Binding Task}"/>
                    </StackPanel>
                </DataTemplate>
            </ListBox.ItemTemplate>
            <ListBox.ItemsPanel>
                <ItemsPanelTemplate>
                    <StackPanel/>
                </ItemsPanelTemplate>
            </ListBox.ItemsPanel>
 */
