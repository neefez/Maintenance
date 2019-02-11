C-- (A4)
Micheal Serino, Noah Moss, Sarah Higgens, Xinyi Lyu, Zack Neefe

Our system is a car rental system. The main point of this system is to browse for and rent cars.
As an unregistered user I can browse cars, search for cars, and create an account. 
As registered user I can rent a car, buy a car, and do everything an unregistered user can.
As an admin, I can add new cars, delete cars, modify descriptions, and blackist registered users.


How to build the system:

	Using Microsoft Visual Studio 2015 or 2017 respectively as the compiler.
	Microsoft Access Database 2016 for the storage.
	

Files Required:

	The "CarRentalSystem" folder with the CarRentalDB.accdb as well as the "RentalSystem" 
	Inside the "RentalSystem" folder there should be:
	AccessAssistant.dll
	AccessAssistant.pdb
	CarRentalSystem.exe
	FormAssistant.dll
	FormAssistant.pbd

Known Bugs:

	* When minimized and then maximized, the UI will flicker for several seconds before returning to normal state.
	* When Creating a new user for the system , the user is taken directly to the search page, when the goal is for them to 
	  be logged in and brought to the dearch page.
	* Pressing the Undo and Redo buttons will bring up the search page with the refreshed results, this is not an intended feature.
 	* The issue comment has to be under 255 characters. This is a problem with the type stored in the database.

Design Deficiencies:

	* The cars represented as images, do not properly dislay as the car information states.
          The car images shown only represent the cars type ie "Sports Car, Luxury, SUV, Van, Hatcheback".
	* The form can at times run slow, and produce a flickering effect.
	* While working, the dependency of a rental with a vehicle, makes it impossible to remove
	  a vehicle with past rentals, So all rentals are removed from the system that are associated
	  with the car.
	* On the blacklist page a comment box is presented, but is not implemented in the database. So the comment is never stored.
	* Can not add additional options into search parameters of the car from admin account. 
	* The forms are never closed when switched between, this is what produces the flickering. We had no time to fix this issue. 

Test Coverage:

	* AccessAssistant.DBController
		- 96.54% covered
			- There would need to exist no database for an OleDbException to be thrown.
			- There are no other stacktypes that can be called in the Save() method.

	* AccessAssistant.DBObject
		- 95.65% covered
			- There would need to be absolutely no records existing in a table within the DB for 0 to be returned.
				- This would involve deleting all records, which we do not want to do

	* CarRentalSystem.Commands.CommandHistory
        	- 81.63% covered
			- The methods do not recognize any subscriptions to StackChangedEvent.
			- There are no other stacktypes that can be called in the GetStack() method.