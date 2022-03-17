using System;

namespace AnkiStudyBreak {
	public class ModConfig
	{
		public bool AnkiBreakOnDayStart { get; set; }
		public int NumAnkiCardsForDayStart { get; set; }
		public bool AnkiBreakAtIntervals { get; set; }
		public int NumAnkiCardsForIntervals { get; set; }
		public int NumHoursForIntervals { get; set; }
		public string AnkiConnectURL { get; set; }
		public ModConfig()
		{
			this.AnkiBreakOnDayStart = true;
			this.NumAnkiCardsForDayStart = 20;
			this.AnkiBreakAtIntervals = true;
			this.NumAnkiCardsForIntervals = 10;
			this.NumHoursForIntervals = 3;
			this.AnkiConnectURL = "http://127.0.0.1:8765";
		}
	}
}