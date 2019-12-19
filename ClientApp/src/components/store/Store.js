import React, { Component } from 'react';
import Aside from './aside/Aside';
import Products from './Products';

class Store extends Component {
  render() {
    return (
      <div className="section">
        <div className="container">
          <div className="row">
            <Aside />
            <Products />
          </div>
        </div>
      </div>
    )
  }
}

export default Store;