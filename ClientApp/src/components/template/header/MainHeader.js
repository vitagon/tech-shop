import React, { Component } from 'react';
import { connect } from 'react-redux';
import { bindActionCreators } from 'redux';
import { FontAwesomeIcon } from '@fortawesome/react-fontawesome'
import { faShoppingCart, faTimesCircle, faArrowCircleRight, faBars } from '@fortawesome/free-solid-svg-icons';
import { faHeart } from '@fortawesome/free-regular-svg-icons';
import './MainHeader.css'
import { TOGGLE_SIDE_NAV_PANEL } from '../../../reducers/navPanelReducer';

class MainHeader extends Component {
  render() {
    return (
      <div id="header">
        <div className="container">
          <div className="row">
            <div className="col-lg-3">
              <div className="header-logo">
                <a href="#" className="logo">
                  <img src="./img/logo.png" alt="" />
                </a>
              </div>
            </div>

            <div className="col-lg-6">
              <div className="header-search">
                <form>
                  <select className="input-select">
                    <option value="0">All Categories</option>
                    <option value="1">Category 01</option>
                    <option value="1">Category 02</option>
                  </select>
                  <input className="input" placeholder="Search here" />
                  <button className="search-btn">Search</button>
                </form>
              </div>
            </div>

            <div className="col-lg-3 clearfix">
              <div className="header-ctn">
                <div>
                  <a href="#">
                    <FontAwesomeIcon icon={faHeart} />
                    <span>Your Wishlist</span>
                    <div className="qty">2</div>
                  </a>
                </div>

                <div className="dropdown">
                  <a className="dropdown-toggle" data-toggle="dropdown" aria-expanded="true">
                    <FontAwesomeIcon icon={faShoppingCart} />
                    <span>Your Cart</span>
                    <div className="qty">3</div>
                  </a>
                  <div className="cart-dropdown">
                    <div className="cart-list">
                      <div className="product-widget">
                        <div className="product-img">
                          <img src="./img/product01.png" alt="" />
                        </div>
                        <div className="product-body">
                          <h3 className="product-name"><a href="#">product name goes here</a></h3>
                          <h4 className="product-price"><span className="qty">1x</span>$980.00</h4>
                        </div>
                        <button className="delete"><FontAwesomeIcon icon={faTimesCircle} /></button>
                      </div>

                      <div className="product-widget">
                        <div className="product-img">
                          <img src="./img/product02.png" alt="" />
                        </div>
                        <div className="product-body">
                          <h3 className="product-name"><a href="#">product name goes here</a></h3>
                          <h4 className="product-price"><span className="qty">3x</span>$980.00</h4>
                        </div>
                        <button className="delete"><FontAwesomeIcon icon={faTimesCircle} /></button>
                      </div>
                    </div>

                    <div className="cart-summary">
                      <small>3 Item(s) selected</small>
                      <h5>SUBTOTAL: $2940.00</h5>
                    </div>
                    <div className="cart-btns">
                      <a href="#">View Cart</a>
                      <a href="#">Checkout  <FontAwesomeIcon icon={faArrowCircleRight} /></a>
                    </div>
                  </div>
                </div>

                <div className="menu-toggle">
                  <a onClick={this.props.toggleSideNavPanel}>
                    <FontAwesomeIcon icon={faBars} />
                    <span>Menu</span>
                  </a>
                </div>
              </div>
            </div>
          </div>
        </div>
      </div>
    );
  }
}

const mapStateToProps = (state) => ({
  showSideNavPanel: state.navPanelReducer.showSideNavPanel
});

const mapDispatchToProps = (dispatch) => bindActionCreators({
  toggleSideNavPanel: () => (dispatch) => dispatch({ type: TOGGLE_SIDE_NAV_PANEL, payload: false })
}, dispatch);

export default connect(mapStateToProps, mapDispatchToProps)(MainHeader);