import React, { Component } from 'react';
import Aside from './aside/Aside';

class Store extends Component {
  render() {
    return (
      <div className="section">
        <div className="container">
          <div className="row">
            <Aside />
          </div>
        </div>
      </div>
    )
  }
}

export default Store;