using System;
using Eto.Forms;
using Eto.Drawing;

namespace MindMapTimelineApp
{
	partial class MainForm : Form
	{
		void InitializeComponent()
		{
			Title = "My Eto Form";
			ClientSize = new Size(400, 350);
			Padding = 10;

			Content = new StackLayout
			{
				Items =
				{
                    "Take a look at my girlfriend\nShe's the only one I've got\nNot much of a girlfriend\nNever seem to get a lot\n\nTake a jumbo across the water\nLike to see America\nSee the girls in California\nI'm hoping it's going to come true\nBut there's not a lot I can do\n\nCould we have kippers for breakfast\nMummy dear, mummy dear\nThey got to have 'em in Texas\n'Cos everyone's a millionaire\n\nI'm a winner, I'm a sinner\nDo you want my autograph\nI'm a loser, what a joker\nI'm playing my jokes upon you\nWhile there's nothing better to do\n\nDon't you look at my girlfriend\nShe's the only one I've got\nNot much of a girlfriend\nNever seem to get a lot\n\nTake a jumbo cross the water\nLike to see America\nSee the girls in California\nI'm hoping it's going to come true\nBut there's not a lot I can do",
					// add more controls here
				}
			};

			// create a few commands that can be used for the menu and toolbar
			var clickMe = new Command { MenuText = "Click Me!", ToolBarText = "Click Me!" };
			clickMe.Executed += (sender, e) => MessageBox.Show(this, "I was clicked!");

			var quitCommand = new Command { MenuText = "Quit", Shortcut = Application.Instance.CommonModifier | Keys.Q };
			quitCommand.Executed += (sender, e) => Application.Instance.Quit();

			var aboutCommand = new Command { MenuText = "About..." };
			aboutCommand.Executed += (sender, e) => new AboutDialog().ShowDialog(this);

			// create menu
			Menu = new MenuBar
			{
				Items =
				{
					// File submenu
					new ButtonMenuItem { Text = "&File", Items = { clickMe } },
					// new ButtonMenuItem { Text = "&Edit", Items = { /* commands/items */ } },
					// new ButtonMenuItem { Text = "&View", Items = { /* commands/items */ } },
				},
				ApplicationItems =
				{
					// application (OS X) or file menu (others)
					new ButtonMenuItem { Text = "&Preferences..." },
				},
				QuitItem = quitCommand,
				AboutItem = aboutCommand
			};

			// create toolbar			
			ToolBar = new ToolBar { Items = { clickMe } };
		}
	}
}
