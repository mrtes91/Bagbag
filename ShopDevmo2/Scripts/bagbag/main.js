$(document).ready(function () {
  $(window).scroll(function () {
    // check if scroll event happened
    if ($(document).scrollTop() > 400) {
      // check if user scrolled more than 50 from top of the browser window
      $('.container-header').css('background-color', 'rgba(52, 58, 64, 0.808)'); // if yes, then change the color of class "navbar-fixed-top" to white (#f8f8f8)
    } else {
      $('.container-header').css('background-color', 'none'); // if not, change it back to transparent
    }
  });
});
