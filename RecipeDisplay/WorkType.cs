using System;
namespace RecipeDisplay {
	
	public interface WorkType {

		Location getLocation();
		String getName();
		bool formallyRecognized();
		bool getContactInfo();

	}
}

