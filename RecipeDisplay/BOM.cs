using System;
using System.Collections.Generic;

namespace RecipeDisplay {
	
	
	public class BOM {

		List <IngredientType> ingredients;


		/// <summary>
		/// Initializes a new instance of the <see cref="T:RecipeDisplay.BOM"/> class.
		/// </summary>
		public BOM() {

			ingredients = new List<IngredientType>();

		}

		public int getTotalWaste() {

			int amount = 0;

			foreach (IngredientType iterator in ingredients) {
				amount += iterator.getWaste();
			}

			return amount;

		}

		public void changeAllToMetric() {

			int number;

			foreach (IngredientType iterator in ingredients) {
				iterator.changeToMetric(number);
			}
		}

		public void changeAllToImperial() {

			int number;

			foreach(IngredientType iterator in ingredients){
				iterator.changeToImperial(number);
		}
	}
}

