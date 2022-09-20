/*
Template Name: Medika
Author: wrappixel
File: scss
*/
$(function () {
  ("use strict");
  // ==============================================================
  //This is for preloader
  // ==============================================================
  $(function () {
    $(".preloader").fadeOut();
  });
  // ==============================================================
  //Tooltip
  // ==============================================================
  $(function () {
    var tooltipTriggerList = [].slice.call(
      document.querySelectorAll('[data-bs-toggle="tooltip"]')
    );
    var tooltipList = tooltipTriggerList.map(function (tooltipTriggerEl) {
      return new bootstrap.Tooltip(tooltipTriggerEl);
    });
  });
  // ==============================================================
  //Popover
  // ==============================================================
  $(function () {
    var popoverTriggerList = [].slice.call(
      document.querySelectorAll('[data-bs-toggle="popover"]')
    );
    var popoverList = popoverTriggerList.map(function (popoverTriggerEl) {
      return new bootstrap.Popover(popoverTriggerEl);
    });
  });
  // ==============================================================
  // For mega menu
  // ==============================================================
  jQuery(document).on("click", ".mega-dropdown", function (e) {
    e.stopPropagation();
  });
  jQuery(document).on("click", ".navbar-nav > .dropdown", function (e) {
    e.stopPropagation();
  });
  $(".dropdown-submenu").click(function () {
    $(".dropdown-submenu > .dropdown-menu").toggleClass("show");
  });

  // ==============================================================
  // Resize all elements
  // ==============================================================
  $("body").trigger("resize");
  // ==============================================================
  //Fix header while scroll
  // ==============================================================
  var wind = $(window);
  wind.on("load", function () {
    var bodyScroll = wind.scrollTop(),
      navbar = $(".topbar");
    if (bodyScroll > 100) {
      navbar.addClass("fixed-header animated slideInDown");
    } else {
      navbar.removeClass("fixed-header animated slideInDown");
    }
  });
  $(window).scroll(function () {
    if ($(window).scrollTop() >= 100) {
      $(".topbar").addClass("fixed-header animated slideInDown");
      $(".bt-top").addClass("visible");
    } else {
      $(".topbar").removeClass("fixed-header animated slideInDown");
      $(".bt-top").removeClass("visible");
    }
  });
  // ==============================================================
  // Animation initialized
  // ==============================================================
  AOS.init();
  // ==============================================================
  // Back to top
  // ==============================================================
  $(".bt-top").on("click", function (e) {
    e.preventDefault();
    $("html,body").animate(
      {
        scrollTop: 0,
      },
      700
    );
  });

  /*----------------------------------------------------*/
  /*  Departments Filter
        /*----------------------------------------------------*/
  var tableCell = $(".cell");
  $(".timeTableFilters li").on("click", function () {
    $(".active").removeClass("active");
    $(this).addClass("active");

    var filter_val = $(this).attr("data-filter");

    tableCell.addClass("bgf");
    if (filter_val == "all") {
      tableCell.removeClass("bgf");
    } else {
      tableCell.addClass("bgf");
      $(".timeTable td." + filter_val).removeClass("bgf");
    }
  });
});
