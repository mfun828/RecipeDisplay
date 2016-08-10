using System;
namespace RecipeDisplay{


	public class Recipe{

		private String title;
		private Chef author;
		private int userRating;
		private Cuisine cuisineType;
		private Procedures directions;
		private BOM ingredients;

		 /// <summary>
		 /// Initializes a new instance of the <see cref="T:RecipeDisplay.Recipe"/> class.
		 /// </summary>
		 /// <param name="titleIn">Title in.</param>

		public Recipe(String titleIn){

			//Sets only the title name of the Recipe. 

			title = titleIn;

		}


		/// <summary>
		/// Copy Constructor for Recipe. 
		/// </summary>
		/// <param name="recipeIn">Recipe in.</param>
		public Recipe(Recipe recipeIn){

			this.title = recipeIn.title;
			this.author = new Chef(recipeIn.author);
			this.userRating = recipeIn.userRating;
			this.cuisineType = new Cuisine(recipeIn.cuisineType);
			this.directions = new Procedures(recipeIn.directions);
			this.ingredients = new BOM(recipeIn.ingredients);


		}

		/// <summary>
		/// Sets the chef.
		/// </summary>
		/// <returns>The chef.</returns>
		/// <param name="authorIn">Author in.</param>
		public void setChef(Chef authorIn){
			this.author = authorIn;

		}


		/// <summary>
		/// Sets the user rating.
		/// </summary>
		/// <returns>The user rating.</returns>
		/// <param name="userRatingIn">User rating in.</param>
		public void setUserRating(int userRatingIn) {
			this.userRating = userRatingIn;

		}
			
	}
}

