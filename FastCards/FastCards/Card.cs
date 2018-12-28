using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace FastCards
{
	public class Card
	{
		public const float learnedTime = maxTime / 2;
		const float maxTime = 30.0f;
		const float failTime = maxTime * 2;
		public const int timesMeasuredPerSide = 3;
		public int weight;
		public int timesMeasured; 
		public string front;
		public string reading;
		public List<string> meaning = new List<string>();
		public bool learned = false;
		public Queue<float> timeUsed = new Queue<float>();

		public Card(string front, string reading, string meaning = "")
		{
			this.front = front;
			this.reading = reading;
			this.meaning.Add(meaning);

			timesMeasured = (meaning == "" ? timesMeasuredPerSide : timesMeasuredPerSide * 2);

			for (int i = 0; i < timesMeasured; i++)
			{
				timeUsed.Enqueue(failTime);
			}
		}

		public Card(string front, string reading, List<string> meaning )
		{
			this.front = front;
			this.reading = reading;
			this.meaning = new List<string>(meaning);

			timesMeasured = timesMeasuredPerSide * 2;

			for(int i = 0; i < timesMeasured; i++)
			{
				timeUsed.Enqueue(failTime);
			}
		}

		public void SaveScore (bool correct, float time)
		{
			if(time > maxTime)
			{
				time = maxTime;
			}
			if(!correct)
			{
				time = failTime;
			}
			timeUsed.Enqueue(time);
			timeUsed.Dequeue();
		}
	}
}
