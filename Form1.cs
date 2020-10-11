using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;

namespace Aquarium
{
	public partial class Form1 : Form
	{
		public Form1(Random random, List<Fish> fish)
		{
			InitializeComponent();
			List<Feed> feed = new List<Feed>();

			PictureBox back = new PictureBox() {
				Image = Aquarium.Properties.Resources.aquarium,
				SizeMode = PictureBoxSizeMode.Zoom,
				Size = ClientSize = new Size(900, 600)
			};
			Controls.Add(back);

			ContextMenu = new ContextMenu(new MenuItem[] { new MenuItem("Feed", (s, e) => { feed.Add(new Feed(back ,random)); }) } );

			foreach (Fish f in fish)
			{
				back.Controls.Add(f.Picture);
				f.Locate();
			}

			Pomp pomp = new Pomp(back, random, new Point(ClientSize.Width - 100, ClientSize.Height), new Point(ClientSize.Width, ClientSize.Height));
			
			Timer timer = new Timer();
			timer.Interval = 1;
			timer.Tick += (s, e) => {
				foreach (Fish f in fish)
					f.Move(feed);
				for (int i = 0; i < feed.Count; ++i)
				{
					Feed f = feed[i];
					if (f.IsAvailable) f.Move();
					else
					{
						f.Dispose();
						feed.RemoveAt(i--);
					}
				}
				pomp.Move();
				back.Invalidate();
			};
			timer.Start();
		}
	}
}
