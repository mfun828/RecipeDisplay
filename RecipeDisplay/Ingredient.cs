using System;
namespace RecipeDisplay{
	
	public class Ingredient : IngredientType{

		private String description;
		private int quantity;
		private Unit unit;
		private int waste;

		/// <summary>
		/// Initializes a new instance of the <see cref="T:RecipeDisplay.Ingredient"/> class.
		/// </summary>
		/// <param name="descriptionIn">Description in.</param>
		/// <param name="quantityIn">Quantity in.</param>
		/// <param name="unitIn">Unit in.</param>
		public Ingredient(String descriptionIn, int quantityIn, Unit unitIn) {

			this.description = descriptionIn;
			this.quantity = quantityIn;
			this.unit = unitIn;
			this.waste = 0;


		}

		/// <summary>
		/// Initializes a new instance of the <see cref="T:RecipeDisplay.Ingredient"/> class.
		/// </summary>
		/// <param name="descriptionIn">Description in.</param>
		/// <param name="quantityIn">Quantity in.</param>
		/// <param name="unitIn">Unit in.</param>
		/// <param name="wasteIn">Waste in.</param>
		public Ingredient(String descriptionIn, int quantityIn, Unit unitIn, int wasteIn) {

			this.description = descriptionIn;
			this.quantity = quantityIn;
			this.unit = unitIn;
			this.waste = wasteIn;


		}

		/// <summary>
		/// Initializes a new instance of the <see cref="T:RecipeDisplay.Ingredient"/> class.
		/// 
		/// Copy Constructor
		/// </summary>
		/// <param name="ingredientIn">Ingredient in.</param>
		public Ingredient(Ingredient ingredientIn) {

			this.description = ingredientIn.description;
			this.quantity = ingredientIn.quantity;
			this.unit = ingredientIn.unit;
			this.waste = ingredientIn.waste;
		}

		/// <summary>
		/// Changes to imperial units of the ingredient, given a specific new quantity 
		/// for the ingredient. 
		/// </summary>
		/// <returns>The to imperial.</returns>
		/// <param name="newQuantity">New quantity.</param>
		public void changeToImperial(int newQuantity) {

			this.unit = Unit.Imperial;
			this.quantity = newQuantity;
		}


		/// <summary>
		/// Changes to metric units of the ingredient, given a specific new quantity 
		/// for the ingredient. 
		/// </summary>
		/// <returns>The to metric.</returns>
		/// <param name="newQuantity">New quantity.</param>
		public void changeToMetric(int newQuantity) {
			this.unit = Unit.Metric;
			this.quantity = newQuantity;
		}

		/// <summary>
		/// Gets the quantity.
		/// </summary>
		/// <returns>The quantity.</returns>
		public int getQuantity() {
			return quantity;
		}

		public int getquantity() {
			return quantity;
		}

		public int getUnit() {
			return (int)unit;

		}

		public string getDescription() {
			return description;
		}

		public int getWaste() {
			return waste;
		}
	}
}

