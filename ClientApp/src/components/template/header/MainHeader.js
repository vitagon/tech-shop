import React, { Component } from 'react';
import { connect } from 'react-redux';
import { bindActionCreators } from 'redux';
import { FontAwesomeIcon } from '@fortawesome/react-fontawesome'
import { faShoppingCart, faTimesCircle, faArrowCircleRight, faBars } from '@fortawesome/free-solid-svg-icons';
import { faHeart } from '@fortawesome/free-regular-svg-icons';
import './MainHeader.css'
import { TOGGLE_SIDE_NAV_PANEL } from '../../../reducers/navPanelReducer';
import { compose } from 'redux';
import {withRouter, Link} from 'react-router-dom';

class MainHeader extends Component {

  constructor(props) {
    super(props);
    this.navigateToCart = this.navigateToCart.bind(this);
  }

  navigateToCart() {
    this.props.history.push('/cart');
  }

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

                <div>
                  <Link to="/cart">
                    <FontAwesomeIcon icon={faShoppingCart} />
                    <span>Your Cart</span>
                    <div className="qty">{this.props.cartItemsQuantity}</div>
                  </Link>
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
  showSideNavPanel: state.navPanelReducer.showSideNavPanel,
  cartItemsQuantity: state.cartReducer.itemsQuantity
});

const mapDispatchToProps = (dispatch) => bindActionCreators({
  toggleSideNavPanel: () => (dispatch) => dispatch({ type: TOGGLE_SIDE_NAV_PANEL, payload: false })
}, dispatch);

export default compose(
  withRouter,
  connect(mapStateToProps, mapDispatchToProps)
)(MainHeader);