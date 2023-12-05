// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
function goToDogDescription(id) {
	/*alert(`You are now being redirected to the ${id} dog description page.`);*/
	window.location.href = `https://animalrescuewebsite.azurewebsites.net/Users/DogDescriptions/${id}`;
	//window.location.href = `https://localhost:7004/Users/DogDescriptions/${id}`;
}