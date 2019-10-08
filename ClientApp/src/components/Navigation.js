import { NavLink } from 'react-router-dom';
import React, { Component } from "react";
import { Navbar, Nav } from 'react-bootstrap';

class Navigation extends Component  {
  render() {
    return (
        <Navbar bg="light" expand="lg">
          <Navbar.Brand href="#home">TechShop</Navbar.Brand>
          <Navbar.Toggle aria-controls="basic-navbar-nav" />
          <Navbar.Collapse id="basic-navbar-nav">
          <Nav className="mr-auto">
              <NavLink className="nav-link" to="/" exact>Home</NavLink>
              <NavLink className="nav-link" to="/categories">Categories</NavLink>
            </Nav>
          </Navbar.Collapse>
        </Navbar>
    );
  }
};

export default Navigation;
