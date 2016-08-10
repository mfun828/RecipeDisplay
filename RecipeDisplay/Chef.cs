using System;
using System.Collections.Generic;

namespace RecipeDisplay {
	public class Chef {

		String name;
		List<WorkType> works;
		List<Cuisine> cuisines;


		public Chef(String nameIn) {

			name = nameIn;
			works = new List<WorkType>();
			cuisines = new List<Cuisine>();
		}
	}
}

