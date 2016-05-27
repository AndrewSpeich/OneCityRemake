$(document).ready(function () {
	alert("Hello!")

	$("#uparrow").on("click", function () {
		e.preventDefault();
		$('#voteCounter').html("<p>Hello!!!</p>!");
	});
	
	$("#downarrow").on("click", function () {
		//e.preventDefault();
		$('#voteCounter').html("World!");
	});

	


});