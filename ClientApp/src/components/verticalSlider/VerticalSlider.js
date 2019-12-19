import React, { Component } from "react";
import Slider from "react-slick";
import SliderArrows from './../sliderArrows/SliderArrows';
import './VerticalSlider.css';

const widgetGroup = (products) => {
  return products.map((product, i) => {
    return (
      <div className="product-widget" key={i}>
        <div className="product-img">
          <img src={product.img} alt="" />
        </div>
        <div className="product-body">
          <p className="product-category">{product.category}</p>
          <h3 className="product-name"><a href="#">{product.name}</a></h3>
          <h4 className="product-price">{product.price} <del className="product-old-price">{product.oldPrice}</del></h4>
        </div>
      </div>
    )
  })
}

const sliderProducts = (products) => {
  let productsOnSlide = 3;
  let length = Math.ceil(products.length / productsOnSlide);
  let arr = Array.apply(null, { length: length }).map(Number.call, Number);
  return arr.map((val, i) => {
    let sliderProducts = products.slice(i * productsOnSlide, i * productsOnSlide + productsOnSlide);
    return (
      <div key={i}>{widgetGroup(sliderProducts)}</div>
    )
  });
}

class VerticalSlider extends Component {

  constructor(props) {
    super(props);
    this.slider = null;

    this.products = this.props.products;
    this.title = this.props.title;
    this.settings = this.props.settings;

    this.next = this.next.bind(this);
    this.previous = this.previous.bind(this);
  }

  next() {
    this.slider.slickNext();
  }

  previous() {
    this.slider.slickPrev();
  }
  
  render() {

    return (
      <>
        <div className="section-title">
          <h4 className="title">{this.title}</h4>
          <div className="section-nav">
            <SliderArrows bottom={'0px'} previous={this.previous} next={this.next} />
          </div>
        </div>

        <Slider ref={c => this.slider = c} className="products-widget-slick" {...this.settings}>
          {sliderProducts(this.products)}
        </Slider>
      </>
    );
  }
};

export default VerticalSlider;