import React, { Component } from 'react';
import noUiSlider from 'nouislider';
import './PriceFilter.css';

class PriceFilter extends Component {

  constructor(props) {
    super(props);
    this.createSlider = this.createSlider.bind(this);
    this.updatePriceSlider = this.updatePriceSlider.bind(this);
    this.updateInputWhenSliderUpdates = this.updateInputWhenSliderUpdates.bind(this);
    this.updateInputAndSliderWhenBtnIsClicked = this.updateInputAndSliderWhenBtnIsClicked.bind(this);
    this.updateSliderOnInputChange = this.updateSliderOnInputChange.bind(this);
  }

  componentDidMount() {
    this.priceSlider = document.getElementById('price-slider');
    this.priceInputMax = document.getElementById('price-max');
    this.priceInputMin = document.getElementById('price-min');
    this.priceInputs = document.getElementsByClassName('input-number');
    this.createSlider();
    this.updateInputWhenSliderUpdates();
    this.updateInputAndSliderWhenBtnIsClicked();
    this.updateSliderOnInputChange();
  }

  createSlider() {
    noUiSlider.create(this.priceSlider, {
      start: [1, 999],
      connect: true,
      step: 1,
      range: {
        'min': 1,
        'max': 999
      }
    });
  }

  updateInputWhenSliderUpdates() {
    let _this = this;
    this.priceSlider.noUiSlider.on('update', function (values, handle) {
      var value = values[handle];
      handle ? _this.priceInputMax.value = value : _this.priceInputMin.value = value;
    });
  }

  updateInputAndSliderWhenBtnIsClicked() {
    let _this = this;
    Array.prototype.forEach.call(this.priceInputs, function (el, index, array) {
      let input = el.querySelector('input[type="number"]'),
        up = el.querySelector('.qty-up'),
        down = el.querySelector('.qty-down');
      
      up.addEventListener('click', function () {
        let value = parseInt(input.value) + 1;
        input.value = value;
        _this.updatePriceSlider(el, value);
      });

      down.addEventListener('click', function () {
        let value = parseInt(input.value) - 1;
        value = value < 1 ? 1 : value;
        input.value = value;
        _this.updatePriceSlider(el, value);
      });
    });
  }

  updateSliderOnInputChange() {
    let _this = this;
    this.priceInputMax.addEventListener('change', function () {
      _this.updatePriceSlider(this.parentElement, this.value)
    });

    this.priceInputMin.addEventListener('change', function () {
      _this.updatePriceSlider(this.parentElement, this.value);
    });
  }

  updatePriceSlider(elem, value) {
    if (elem.classList.contains('price-min')) {
      console.log('min');
      this.priceSlider.noUiSlider.set([value, null]);
    } else if (elem.classList.contains('price-max')) {
      console.log('max');
      this.priceSlider.noUiSlider.set([null, value]);
    }
  }

  render() {
    return (
      <div className="aside">
        <h3 className="aside-title">Price</h3>
        <div className="price-filter">
          <div id="price-slider"></div>
          <div className="input-number price-min">
            <input id="price-min" type="number" />
            <span className="qty-up">+</span>
            <span className="qty-down">-</span>
          </div>
          <span>-</span>
          <div className="input-number price-max">
            <input id="price-max" type="number" />
            <span className="qty-up">+</span>
            <span className="qty-down">-</span>
          </div>
        </div>
      </div>
    )
  }
}

export default PriceFilter;