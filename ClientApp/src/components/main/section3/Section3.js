import React, { Component } from "react";
import TabsWithSliders from '../../tabsWithSlider/TabsWithSliders';
import './Section3.css';

const topSellingProducts = {
  laptops: [
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
  ],
  smartphones: [
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
    }
  ]
}

class Section3 extends Component {

  render() {
    let title = 'Top selling';
    let products = topSellingProducts;
    let settings = {
      dots: false,
      infinite: true,
      speed: 500,
      slidesToShow: 4,
      slidesToScroll: 4,
      arrows: false
    }
    let sliders = ['laptops', 'smartphones', 'cameras', 'accessories'];

    return (
      <TabsWithSliders
        title={title}
        products={products}
        settings={settings}
        sliders={sliders}
      />
    )
  }
};

export default Section3;