import React, { Component } from 'react';
import { BrowserRouter, Route, Switch } from 'react-router-dom';
import Home from './components/Home';
import Navigation from './components/Navigation';
import Categories from './components/categories/Categories';


class App extends Component {
  render() {
    return (
      <BrowserRouter>
        <div>
          <Navigation />
          <Switch>
            <Route path='/' exact component={Home} />
            <Route path='/categories' component={Categories} />
          </Switch>
        </div>
      </BrowserRouter>
    )
  }
}

export default App;
