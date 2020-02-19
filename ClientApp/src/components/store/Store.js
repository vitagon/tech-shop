import React, { Component } from 'react';
import Aside from './aside/Aside';
import Products from './Products';
import { connect } from 'react-redux';
import { withRouter } from 'react-router-dom';
import { bindActionCreators, compose } from 'redux';
import { getProducts } from '../../actions/productsActions';
import qs from 'query-string';

class Store extends Component {

  constructor(props) {
    super(props);
    const parsedQueryStr = qs.parse(this.props.location.search);
    this.props.getProducts(Object.assign({}, parsedQueryStr, {
      categoryUrl: this.props.match.params.categoryUrl
    }));
  }

  componentDidUpdate(prevProps, prevState) {
    if (prevProps.match.params.categoryUrl !== this.props.match.params.categoryUrl ||
        prevProps.location.search !== this.props.location.search) {
      const parsedQueryStr = qs.parse(this.props.location.search);
      this.props.getProducts(Object.assign({}, parsedQueryStr, {
        categoryUrl: this.props.match.params.categoryUrl
      }));
    }
  }

  render() {
    return (
      <div className="section">
        <div className="container">
          <div className="row">
            <Aside />
            <Products />
          </div>
        </div>
      </div>
    )
  }
}

const mapDispatchToProps = (dispatch) => bindActionCreators({
  getProducts: getProducts
}, dispatch);

export default compose(
  withRouter,
  connect(null, mapDispatchToProps)
)(Store);