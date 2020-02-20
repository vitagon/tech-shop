import React, { Component } from 'react';
import noUiSlider from 'nouislider';
import './PriceFilter.css';

const DEFAULT_MIN_PRICE = 1.00;
const DEFAULT_MAX_PRICE = 999.00;

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
    this.initializeInputs();

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
        'min': DEFAULT_MIN_PRICE,
        'max': DEFAULT_MAX_PRICE
      }
    });
  }

  initializeInputs() {
    this.priceInputMin.value = DEFAULT_MIN_PRICE;
    this.priceInputMax.value = DEFAULT_MAX_PRICE;
  }

  showApplyBtn(el, value) {
    let aside = el.closest('.aside');
    let asideTop = aside.getBoundingClientRect().top;
    let curElTop = el.getBoundingClientRect().top;
    let curElBottom = el.getBoundingClientRect().bottom;
    let curElHalfHeight = Math.round(Math.abs(curElTop - curElBottom) / 2);
    let distance = Math.abs(asideTop - curElTop) + curElHalfHeight;
    console.log(el.getBoundingClientRect());

    let applyFiltersBtn = aside.querySelector('.apply-filters-btn');
    let btnHalfHeight = Math.round(applyFiltersBtn.offsetHeight / 2);
    let top = distance - btnHalfHeight;
    applyFiltersBtn.style.top = `${top}px`;
    applyFiltersBtn.style.visibility = 'visible';
    setTimeout(function () {
      applyFiltersBtn.style.visibility = 'hidden';
    }, 3500);
  }

  updateInputWhenSliderUpdates() {
    let _this = this;
    this.priceSlider.noUiSlider.on('change', function (values, handle) {
      var value = Math.round(values[handle]);

      handle ? _this.priceInputMax.value = value : _this.priceInputMin.value = value;
      _this.showApplyBtn(_this.priceSlider, value);
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
    let val = Math.round(value);
    if (elem.classList.contains('price-min')) {
      this.showApplyBtn(this.priceInputMin, val);
      this.priceSlider.noUiSlider.set([val, null]);
    } else if (elem.classList.contains('price-max')) {
      this.showApplyBtn(this.priceInputMax, val);
      this.priceSlider.noUiSlider.set([null, val]);
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

        <div className="apply-filters-btn">
          <button className="apply-filters-btn__button">Apply</button>
        </div>
      </div>
    )
  }
}

export default PriceFilter;