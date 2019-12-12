import React, { Component } from "react";
import Slider from "react-slick";
import { SliderProducts } from './SliderProducts';
import { Tab, Nav } from "react-bootstrap";
import './TabsWithSliders.css';

class TabsWithSliders extends Component {
  constructor(props) {
    super(props);
    this.next = this.next.bind(this);
    this.previous = this.previous.bind(this);
    this.setActiveSlider = this.setActiveSlider.bind(this);
    this.initSliderSettings = this.initSliderSettings.bind(this);
    this.initSliderComponentsRefs = this.initSliderComponentsRefs.bind(this);

    this.defaultSettings = this.props.settings;
    this.sliders = this.props.sliders;
    this.title = this.props.title;
    this.products = this.props.products;

    this.sliderComponentsRefs = this.initSliderComponentsRefs();
    this.state = {
      activeSlider: 'laptops',
      settings: this.initSliderSettings()
    }
  }

  initSliderComponentsRefs() {
    let slidersRefs = {};
    for (let sliderName of this.sliders) {
      slidersRefs[sliderName] = null;
    }
    return slidersRefs;
  }

  initSliderSettings() {
    let settings = {};
    for (let key of this.sliders) {
      settings[key] = this.defaultSettings;
    }
    return settings;
  }

  next() {
    this.sliderComponentsRefs[this.state.activeSlider].slickNext();
  }

  previous() {
    this.sliderComponentsRefs[this.state.activeSlider].slickPrev();
  }

  setActiveSlider(slider) {
    let keys = Object.keys(this.state.settings);
    let settings = {};
    for (let key of keys) {
      settings[key] = 'unslick';
    }

    // "unslick" all sliders AND only then we activate our current slider
    this.setState({
      ...this.state,
      activeSlider: slider,
      settings: settings
    }, function () {
      // `this.state` has new data that was set up above
      // you can check it
      // console.log(this.state);
      // OR you can use ASYNC/AWAIT
      settings[slider] = this.defaultSettings;
      this.setState({
        ...this.state,
        settings: settings
      })
    });
  }

  render() {
    let slickNav = (
      <div id="slick-nav-1" className="products-slick-nav">
        <button className="slick-prev slick-arrow" style={{ display: 'inline-block' }} onClick={this.previous}>Prev</button>
        <button className="slick-next slick-arrow" style={{ display: 'inline-block' }} onClick={this.next}>Next</button>
      </div>
    );

    return (
      <div className="section">
        <div className="container">
          <div className="row">

            <Tab.Container id="my-tabs-example" defaultActiveKey="laptops" activeKey={this.state.activeSlider} onSelect={k => { this.setActiveSlider(k) }}>
              <div className="col-md-12">
                <div className="section-title">
                  <h3 className="title">{this.title}</h3>
                  <div className="section-tab-nav section-nav">
                    <Nav as="ul" defaultActiveKey="#laptops">
                      {this.sliders.map((sliderName, i) => {
                        let sliderTitle = sliderName[0].toUpperCase() + sliderName.slice(1);
                        return (
                          <Nav.Item key={i} as="li">
                            <Nav.Link href={'#' + sliderName} eventKey={sliderName}>{sliderTitle}</Nav.Link>
                          </Nav.Item>
                        );
                      })}
                    </Nav>
                  </div>
                </div>
              </div>

              <div className="col-md-12">
                <Tab.Content>
                  {this.sliders.map((sliderName, i) => {
                    return (
                      this.products[sliderName] !== undefined &&
                      (
                        <Tab.Pane eventKey={sliderName} key={i}>
                          <Slider
                            ref={c => (this.sliderComponentsRefs[sliderName] = c)}
                            {...this.state.settings[sliderName]}
                            className="products-slick"
                          >
                            {SliderProducts(this.products[sliderName])}
                          </Slider>
                          {slickNav}
                        </Tab.Pane>
                      )
                    );
                  })}
                </Tab.Content>
              </div>
            </Tab.Container>

          </div>
        </div>
      </div >
    );
  }
};

export default TabsWithSliders;