using System;
namespace RecipeDisplay {
	
	public interface IngredientType {

		int getquantity();
		void changeToImperial(int newQuantity);
		void changeToMetric(int newQuantity);
		int getUnit();
		String getDescription();
		int getWaste();

	}
}

