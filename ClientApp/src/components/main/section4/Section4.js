import React, { Component } from "react";
import VerticalSlider from '../../verticalSlider/VerticalSlider';
import './Section4.css';

const dummyArr = [
  {
    id: 1,
    img: './img/product01.png',
    sale: '-30%',
    new: true,
    category: 'Category',
    name: 'product name goes here',
    price: '$980.00',
    oldPrice: '$990.00',
    rating: 5
  },
  {
    id: 2,
    img: './img/product02.png',
    sale: '',
    new: true,
    category: 'Category',
    name: 'product name goes here',
    price: '$980.00',
    oldPrice: '$990.00',
    rating: 4
  },
  {
    id: 3,
    img: './img/product03.png',
    sale: '-30%',
    new: false,
    category: 'Category',
    name: 'product name goes here',
    price: '$980.00',
    oldPrice: '$990.00',
    rating: 4
  },
  {
    id: 4,
    img: './img/product04.png',
    sale: '',
    new: false,
    category: 'Category',
    name: 'product name goes here',
    price: '$980.00',
    oldPrice: '$990.00',
    rating: 5
  },
  {
    id: 5,
    img: './img/product05.png',
    sale: '',
    new: false,
    category: 'Category',
    name: 'product name goes here',
    price: '$980.00',
    oldPrice: '$990.00',
    rating: 5
  },
  {
    id: 6,
    img: './img/product06.png',
    sale: '',
    new: false,
    category: 'Category',
    name: 'product name goes here',
    price: '$980.00',
    oldPrice: '$990.00',
    rating: 4
  },
  {
    id: 7,
    img: './img/product07.png',
    sale: '',
    new: false,
    category: 'Category',
    name: 'product name goes here',
    price: '$980.00',
    oldPrice: '$990.00',
    rating: 2
  },
];

const dummyProducts = {
  col1: dummyArr,
  col2: dummyArr,
  col3: dummyArr
}

class Section4 extends Component {
  render() {
    let title = 'Top selling';
    let settings = {
      infinite: true,
      speed: 300,
      dots: false,
      arrows: false,
    }
    return (
      <div className="section">
        <div className="container">
          <div className="row">
            <div className="col-md-4 col-xs-6">
              <VerticalSlider
                products={dummyProducts.col1}
                title={title}
                settings={settings}
              />
            </div>

            <div className="col-md-4 col-xs-6">
              <VerticalSlider
                products={dummyProducts.col2}
                title={title}
                settings={settings}
              />
            </div>

            <div className="clearfix visible-sm visible-xs"></div>

            <div className="col-md-4 col-xs-6">
              <VerticalSlider
                products={dummyProducts.col3}
                title={title}
                settings={settings}
              />
            </div>

          </div>
        </div>
      </div>
    );
  }
};

export default Section4;