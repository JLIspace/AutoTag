﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoTag {
	class FileMetadata {
		public enum Types { TV, Movie };

		// Common fields
		public Types FileType;
		public String Title;
		public String Overview;
		public String CoverURL;
		public String CoverFilename;
		public bool Success;
		public bool Complete;

		// TV specific fields
		public String SeriesName;
		public int Season;
		public int Episode;

		// Movie specific fields
		public DateTime Date;

		public FileMetadata(Types type) {
			FileType = type;
			Success = true;
			Complete = true;
		}

		public String ToString() {
			if (FileType == Types.TV) {
				return SeriesName + "S" + Season.ToString("00") + "E" + Episode.ToString("00") + " (" + Title + ")";
			} else {
				return Title + "(" + Date.Year + ")";
			}
		}
	}
}