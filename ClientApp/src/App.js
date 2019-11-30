import React, { Component } from 'react';
import { BrowserRouter } from 'react-router-dom';
import Router from './Router';
import Header from './components/template/header/Header';
import Footer from './components/template/footer/Footer';
import Navigation from './components/template/navigation/Navigation';
import Curtain from './components/template/curtain/Curtain';

class App extends Component {
  render() {
    return (
      <BrowserRouter>
        <div>
          <Header></Header>
          <Navigation></Navigation>
          <Curtain></Curtain>
          <Router></Router>
          <Footer></Footer>
        </div>
      </BrowserRouter>
    )
  }
}

export default App;
