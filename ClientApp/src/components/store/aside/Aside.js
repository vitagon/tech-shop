import React, { Component } from 'react';
import CategoriesFilter from './CategoriesFilter';
import PriceFilter from './PriceFilter';
import BrandsFilter from './BrandsFilter';
import TopSelling from './TopSelling';
import './Aside.css';

class Aside extends Component {
  render() {
    return (
      <div id="aside" className="col-md-3">
        <CategoriesFilter />
        <PriceFilter />
        <BrandsFilter />
        <TopSelling />
      </div>
    )
  }
}

export default Aside;