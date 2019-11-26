import { NavLink } from 'react-router-dom';
import React, { Component } from "react";
import { connect } from 'react-redux';
import './Navigation.css';
import { bindActionCreators } from 'redux';

class Navigation extends Component {
  render() {
    return (
      <nav id="navigation">
        <div className="container">
          <div id="responsive-nav" className={this.props.showSideNavPanel ? 'active' : null}>
            <ul className="main-nav nav">
              <li className="nav-item active"><NavLink className="nav-link" to="/" exact>Home</NavLink></li>
              <li className="nav-item"><NavLink className="nav-link" to="/hot-deals">Hot Deals</NavLink></li>
              <li className="nav-item"><NavLink className="nav-link" to="/categories">Categories</NavLink></li>
              <li className="nav-item"><NavLink className="nav-link" to="/categories/laptops">Laptops</NavLink></li>
              <li className="nav-item"><NavLink className="nav-link" to="/categories/smartphones">Smartphones</NavLink></li>
              <li className="nav-item"><NavLink className="nav-link" to="/categories/cameras">Cameras</NavLink></li>
              <li className="nav-item"><NavLink className="nav-link" to="/categories/accessories">Accessories</NavLink></li>
            </ul>
          </div>
        </div>
      </nav>
    );
  }
};

const mapStateToProps = (state) => ({
  showSideNavPanel: state.navPanelReducer.showSideNavPanel
});

const mapDispatchToProps = (dispatch) => bindActionCreators({
  //showSideNavPanel: () => (dispatch) => dispatch({ type: SHOW_SIDE_NAV_PANEL, payload: false })
});

export default connect(mapStateToProps, mapDispatchToProps)(Navigation);
