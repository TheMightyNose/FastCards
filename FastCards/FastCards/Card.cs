using System;
using System.Collections.Generic;
using System.Text;

namespace FastCards
{
	class Card
	{
		public string front;
		public string reading;
		public string meaning;

		public Card(string front, string reading, string meaning = "")
		{
			this.front = front;
			this.reading = reading;
			this.meaning = meaning;
		}
	}
}
