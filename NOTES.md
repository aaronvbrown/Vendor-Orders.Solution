Vendor and Order Tracker
Pierre was so pleased with your console app for his bakery that he wants to hire you for a new project. This time, he would like you to build him an MVC application to help him track the vendors that purchase baked goods from him and the orders belonging to those vendors.

For example, Pierre might supply croissants to a vendor called "Suzie's Cafe" once a week. Pierre may want to create a new Vendor to represent the cafe and add new Orders to it to help keep track of his expanding business relationships.

Use Razor to display information on each page.

*  Create a Vendor class. This class should include properties for the vendor's name, a description of the vendor, a List of Orders belonging to the vendor, and any other properties you would like to include.
*  Create an Order class. This class should include properties for the title, the description, the price, the date, and any other properties you would like to include.
*  The homepage of the app at the root path (localhost:5000/) should be a splash page welcoming Pierre and providing him with a link to a Vendors page.
*  The vendors page should contain a link to a page presenting Pierre with a form he can fill out to create a new Vendor. After the form is submitted, the new Vendor object should be saved into a static List and Pierre should be routed back to the homepage.
*  Pierre should be able to click a Vendor's name and go to a new page that will display all of that Vendor's orders.
*  Pierre should be provided with a link to a page presenting him with a form to create a new Order for a particular Vendor. Hint: The route for this page might look something like: "/vendors/1/orders/new".


Objectives

* Your code will be reviewed for the following objectives:

* A splash page is used.
* Project has Vendor and Order classes.
* Project uses two or more controllers.
* Models are thoroughly tested.
* GET and POST requests/responses are used successfully.
* MVC routes follow RESTful conventions.
* Project is in a polished, portfolio-quality state.
* The prompt’s required functionality and baseline project requirements are in place by the deadline.