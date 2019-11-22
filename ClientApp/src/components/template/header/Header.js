import React, { Component } from "react";
import TopHeader from './TopHeader';
import MainHeader from './MainHeader';

class Header extends Component {
  render() {
    return (
      <header>
        <TopHeader></TopHeader>
        <MainHeader></MainHeader>
      </header>
    );
  }
};

export default Header;
