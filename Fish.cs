using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;

namespace Aquarium
{
	public class Fish
	{
		private Random random;
		private bool foundFeed;
		private int xVelocity, vy;
		private int vx
		{
			get { return xVelocity; }
			set
			{ 
				if (value < 0 && xVelocity >= 0 || value >= 0 && xVelocity < 0)
					Picture.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);
				xVelocity = value;
			}
		}
		public PictureBox Picture { get; private set; }
		public string Name { get; set; }
		public int MaxVelocity { get; set; }
		public Fish(Random random, string name, int maxVelocity)
		{
			Picture = new PictureBox() {
				Image = Properties.Resources.fish,
				SizeMode = PictureBoxSizeMode.Zoom,
				Size = new Size(80, 45),
				BackColor = Color.Transparent
			};
			this.random = random;
			Name = name;
			MaxVelocity = maxVelocity;

			RandomDirection();
		}
		private void RandomDirection()
		{
			do vx = random.Next(-MaxVelocity, MaxVelocity + 1);
			while (vx == 0);
			do vy = random.Next(-MaxVelocity, MaxVelocity + 1);
			while (vy == 0);
		}
		public void Locate()
		{
			Picture.Location = new Point(
				random.Next(Picture.Parent.Width - Picture.Width),
				random.Next(Picture.Parent.Height - Picture.Height));
		}
		public void Move(List<Feed> feed)
		{
			if (feed.Count != 0)
			{
				foundFeed = true;
				Point leftMouth = new Point(Picture.Location.X, Picture.Location.Y + Picture.Height / 2),
					rightMouth = new Point(Picture.Location.X + Picture.Width, leftMouth.Y);

				Feed priority = feed.OrderBy(f => (int)Math.Round(Math.Min(
					Math.Sqrt(Math.Pow(leftMouth.X - f.Location.X, 2) + Math.Pow(leftMouth.Y - f.Location.Y, 2)),
					Math.Sqrt(Math.Pow(rightMouth.X - f.Location.X, 2) + Math.Pow(rightMouth.Y - f.Location.Y, 2))))).First();

				Point target = new Point(priority.Location.X + priority.Side / 2, priority.Location.Y + priority.Side / 2),
					mouth = 
						Math.Pow(leftMouth.X - priority.Location.X, 2) <
						Math.Pow(rightMouth.X - priority.Location.X, 2) ? leftMouth : rightMouth;

				int dx = Math.Abs(target.X - mouth.X), dy = Math.Abs(target.Y - mouth.Y);
				vx = dx < MaxVelocity ? dx : MaxVelocity;
				vy = dy < MaxVelocity ? dy : MaxVelocity;
				vx *= target.X < mouth.X ? -1 : 1;
				vy *= target.Y < mouth.Y ? -1 : 1;

				if (mouth.X + vx == target.X && mouth.Y + vy == target.Y)
				{
					priority.Dispose();
					feed.Remove(priority);
					foundFeed = false;
					RandomDirection();
				}
			}
			else
			{
				if (foundFeed)
				{
					foundFeed = false;
					RandomDirection();
					return;
				}
				if (random.NextDouble() < MaxVelocity * 0.004)
					RandomDirection();
				if (Picture.Location.X + Picture.Width >= Picture.Parent.Width || Picture.Location.X <= 0)
				{
					Picture.Location = new Point(Picture.Location.X <= 0 ? 0 : Picture.Parent.Width - Picture.Width, Picture.Location.Y);
					vx = vx < 0 ? random.Next(1, MaxVelocity + 1) : random.Next(-MaxVelocity, 0);
				}
				if (Picture.Location.Y + Picture.Height >= Picture.Parent.Height || Picture.Location.Y <= 0)
				{
					Picture.Location = new Point(Picture.Location.X, Picture.Location.Y <= 0 ? 0 : Picture.Parent.Height - Picture.Height);
					vy = vy < 0 ? random.Next(1, MaxVelocity + 1) : random.Next(-MaxVelocity, 0);
				}
			}
			Picture.Location = new Point(Picture.Location.X + vx, Picture.Location.Y + vy);
		}
		public override string ToString()
		{
			return $"{Name} ({MaxVelocity})";
		}
	}
}
