import React, { Component } from 'react';
import { ProductsGridView } from './products/ProductsGridView';
import ProductsListView from './products/ProductsListView';
import { FontAwesomeIcon } from '@fortawesome/react-fontawesome';
import { faTh, faThList, faAngleRight, faAngleLeft, faAngleDoubleRight, faAngleDoubleLeft } from '@fortawesome/free-solid-svg-icons';
import { connect } from 'react-redux';
import { Link, withRouter } from 'react-router-dom';
import './Products.css'
import qs from 'query-string';
import { bindActionCreators, compose } from 'redux';
import { getProducts } from '../../actions/productsActions';


class Products extends Component {
  constructor(props) {
    super(props);
    this.state = {
      productsView: 'list',
      curPageSizeOption: 10
    }
    this.setGridView = this.setGridView.bind(this);
    this.setListView = this.setListView.bind(this);
    this.getNextPageUrl = this.getNextPageUrl.bind(this);
    this.getPrevPageUrl = this.getPrevPageUrl.bind(this);
    this.changePageSize = this.changePageSize.bind(this);
    this.getFirstPageUrl = this.getFirstPageUrl.bind(this);
    this.getLastPageUrl = this.getLastPageUrl.bind(this);
    this.generatePageNumbersForPagination = this.generatePageNumbersForPagination.bind(this);
    
    this.pageSizeOptions = [2, 5, 10, 20, 50];
  }

  setGridView() {
    this.setState({
      ...this.state,
      productsView: 'grid'
    });
  }

  setListView() {
    this.setState({
      ...this.state,
      productsView: 'list'
    });
  }

  getNextPageUrl(url, parsedQueryStr) {
    let queryObj = Object.assign({}, parsedQueryStr, { pageNumber: this.props.metadata.CurrentPage + 1 });
    let queryStr = qs.stringify(queryObj);
    return Object.assign({}, {}, {
      pathname: url,
      search: `?${queryStr}`
    });
  }

  getPrevPageUrl(url, parsedQueryStr) {
    let queryObj = Object.assign({}, parsedQueryStr, { pageNumber: this.props.metadata.CurrentPage - 1 });
    let queryStr = qs.stringify(queryObj);
    return Object.assign({}, {}, {
      pathname: url,
      search: `?${queryStr}`
    });
  }

  getFirstPageUrl(url, parsedQueryStr) {
    let queryObj = Object.assign({}, parsedQueryStr, { pageNumber: 1 });
    let queryStr = qs.stringify(queryObj);
    return Object.assign({}, {}, {
      pathname: url,
      search: `?${queryStr}`
    });
  }

  getLastPageUrl(url, parsedQueryStr) {
    let queryObj = Object.assign({}, parsedQueryStr, { pageNumber: this.props.metadata.TotalPages });
    let queryStr = qs.stringify(queryObj);
    return Object.assign({}, {}, {
      pathname: url,
      search: `?${queryStr}`
    });
  }

  changePageSize(event) {
    this.setState({
      ...this.state,
      curPageSizeOption: event.target.value
    });
    let parsedQueryStr = qs.parse(this.props.location.search);
    let queryObj = Object.assign({}, parsedQueryStr, { pageSize: event.target.value });
    let queryStr = qs.stringify(queryObj);
    this.props.history.push(this.props.match.url + `?${queryStr}`);
  }

  generatePageNumbersForPagination() {
    let maxSpaceForPagination = 8,
        defaultLeftSpace = 4,
        defaultRightSpace = 3,
        numbersArr = [];

    let curPage = this.props.metadata.CurrentPage;
    let totalPages = this.props.metadata.TotalPages;
    let prevPage = curPage - 1;
    let nextPage = curPage + 1;

    let showOnTheLeft = curPage < 5 ? curPage - 1 : 4;
    let showOnTheRight = curPage > totalPages - 3 ? totalPages - curPage : 3;

    if (showOnTheLeft < 4 && showOnTheRight === 3) showOnTheRight = showOnTheRight + (4 - showOnTheLeft);
    if (showOnTheLeft === 4 && showOnTheRight < 3) showOnTheLeft = showOnTheLeft + (3 - showOnTheRight);

    if (this.props.metadata.HasPrevious) {
      for (let i = prevPage, count = 0; (i >= 1 && count < showOnTheLeft); i-- , count++) {
        numbersArr.unshift(i);
      }
    }

    numbersArr.push(this.props.metadata.CurrentPage);

    if (this.props.metadata.HasNext) {
      for (let i = nextPage, count = 0; (i <= totalPages && count < showOnTheRight); i++ , count++) {
        numbersArr.push(i);
      }
    }
    return numbersArr;
  }

  render() {
    let url = this.props.match.url;
    let parsedQueryStr = qs.parse(this.props.location.search);
    return (
      <div id="store" className="col-md-9">
        <div className="store-filter clearfix">
          <div className="store-sort">
            <label>
              Sort By:
							<select className="input-select" disabled>
                <option value="0">Popular</option>
                <option value="1">Position</option>
              </select>
            </label>

            <label>
              Show:
							<select className="input-select" onChange={this.changePageSize} value={this.state.curPageSizeOption}>
                {this.pageSizeOptions.map((val, index) => {
                  return (<option value={val} key={index}>{val}</option>);
                })}
              </select>
            </label>
          </div>
          <ul className="store-grid">
            <li className={this.state.productsView === 'grid' ? 'active' : ''} onClick={this.setGridView}><FontAwesomeIcon icon={faTh} /></li>
            <li className={this.state.productsView === 'list' ? 'active' : ''} onClick={this.setListView}><FontAwesomeIcon icon={faThList} /></li>
          </ul>
        </div>

        <div className="row">
          {this.state.productsView === 'grid' && ProductsGridView(this.props.products)}
          {this.state.productsView === 'list' && <ProductsListView products={this.props.products} />}
        </div>


        <div className="store-filter clearfix">
          <div className="store-qty mb-2">Showing {this.props.metadata.PageSize} - {this.props.metadata.TotalCount} products</div>
          <ul className="store-pagination">
            {this.props.metadata.CurrentPage !== 1 ?
              (<li>
                <Link to={location => this.getFirstPageUrl(url, parsedQueryStr)}>
                  <FontAwesomeIcon icon={faAngleDoubleLeft} />
                </Link>
              </li>) :
              null}

            {this.props.metadata.HasPrevious ?
              (<li>
                <Link to={location => this.getPrevPageUrl(url, parsedQueryStr)}>
                  <FontAwesomeIcon icon={faAngleLeft} />
                </Link>
              </li>)
              : null}

            {this.generatePageNumbersForPagination().map((val) => {
              let queryObj = Object.assign({}, parsedQueryStr, { pageNumber: val });
              let queryStr = qs.stringify(queryObj);
              let urlWithQueryParams = url + '?' + queryStr;
              if (this.props.metadata.CurrentPage == val) {
                return (<li className="active" key={val}>{val}</li>);
              }
              return (<li key={val}><Link to={urlWithQueryParams}>{val}</Link></li>);
            })}

            {this.props.metadata.HasNext ?
              (<li>
                <Link to={location => this.getNextPageUrl(url, parsedQueryStr)}>
                  <FontAwesomeIcon icon={faAngleRight} />
                </Link>
              </li>) :
              null}

            {this.props.metadata.CurrentPage !== this.props.metadata.TotalPages ?
              (<li>
                <Link to={location => this.getLastPageUrl(url, parsedQueryStr)}>
                  <FontAwesomeIcon icon={faAngleDoubleRight} />
                </Link>
              </li>) :
              null}
          </ul>
        </div>
      </div>
    )
  }
}

const mapStateToProps = (state, ownProps) => ({
  products: state.productsReducer.products,
  metadata: state.productsReducer.metadata
});

export default compose(
  connect(mapStateToProps, null),
  withRouter
)(Products);
