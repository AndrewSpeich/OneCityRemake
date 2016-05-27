$(document).ready(function () {
	alert("Hello!")


	$("#uparrow").find('p').on("click", function (e) {
		e.preventDefault();

		$("#voteCounter").load("Hello!");
	});



	//$("#uparrow").on("click", function () {
	//	e.preventDefault();
	//	$('#voteCounter').html("<p>Hello!!!</p>!");
	//});
	
	$("#downarrow").on("click", function () {
		//e.preventDefault();
		$('#voteCounter').html("World!");
	});

	


});